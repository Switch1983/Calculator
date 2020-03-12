using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using SampleCalc.Commands;
using System.Collections.ObjectModel;

namespace SampleCalc.ViewModels
{
    class ScientificViewModel : StandardViewModel
    {
        private DelegateCommand cosMathCommand;
        private DelegateCommand tanMathCommand;
        private DelegateCommand sinMathCommand;

        public ICommand COSMathCommand
        {
            get
            {
                if (cosMathCommand == null)
                {
                    cosMathCommand = new DelegateCommand(COSMathCom);
                }
                return cosMathCommand;
            }
        }
        public ICommand TANMathCommand
        {
            get
            {
                if (tanMathCommand == null)
                {
                    tanMathCommand = new DelegateCommand(TANMathCom);
                }
                return tanMathCommand;
            }
        }
        public ICommand SINMathCommand
        {
            get
            {
                if (sinMathCommand == null)
                {
                    sinMathCommand = new DelegateCommand(SINMathCom);
                }
                return sinMathCommand;
            }
        }

        private void COSMathCom()
        {
            calcDisplay = calculator.COS(double.Parse(calcDisplay)).ToString();
            action = _CLEAR;
            OnPropertyChanged("Sum");
        }
        private void TANMathCom()
        {
            calcDisplay = calculator.TAN(double.Parse(calcDisplay)).ToString();
            action = _CLEAR;
            OnPropertyChanged("Sum");
        }
        private void SINMathCom()
        {
            calcDisplay = calculator.SIN(double.Parse(calcDisplay)).ToString();
            action = _CLEAR;
            OnPropertyChanged("Sum");
        }
    }
}
