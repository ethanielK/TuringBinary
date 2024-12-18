using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CustomCommandMVVM.Controls
{
    public partial class ColorCommandSource : UserControl, ICommandSource
    {
        // 继承自 ICommandSource 的三个属性
        public ICommand Command => throw new NotImplementedException();

        public object CommandParameter => throw new NotImplementedException();

        public IInputElement CommandTarget => throw new NotImplementedException();

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            if (Command != null)
            {
                Command.Execute(this.CommandTarget);
            }

            //if(Command != null && Command.CanExecute(CommandParameter))
            //{
            //    Command.Execute(CommandParameter);
            //}
        }
    }
}
