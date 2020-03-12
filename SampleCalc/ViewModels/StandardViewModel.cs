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
    class StandardViewModel : ViewModelBase
    {
        protected const uint _NO_ACTION = 0;
        protected const uint _CLEAR = 1;
        protected const uint _DIVIDE = 2;
        protected const uint _MULTIPLY = 3;
        protected const uint _SUBTRACT = 4;
        protected const uint _ADD = 5;

        protected Models.Calculator calculator;
        protected Models.Calculator memory;
        protected string calcDisplay;
        protected uint action;

        private DelegateCommand exitCommand;
        private DelegateCommand standardCommand;
        private DelegateCommand scientificCommand;
        private DelegateCommand mcMathCommand;
        private DelegateCommand mrMathCommand;
        private DelegateCommand msMathCommand;
        private DelegateCommand mplusMathCommand;
        private DelegateCommand mminusMathCommand;
        private DelegateCommand ceMathCommand;
        private DelegateCommand cmathCommand;
        private DelegateCommand mplusminusMathCommand;
        private DelegateCommand sqrtMathCommand;
        private DelegateCommand oneMathCommand;
        private DelegateCommand twoMathCommand;
        private DelegateCommand threeMathCommand;
        private DelegateCommand fourMathCommand;
        private DelegateCommand fiveMathCommand;
        private DelegateCommand sixMathCommand;
        private DelegateCommand sevenMathCommand;
        private DelegateCommand eightMathCommand;
        private DelegateCommand nineMathCommand;
        private DelegateCommand zeroMathCommand;
        private DelegateCommand divMathCommand;
        private DelegateCommand mulMathCommand;
        private DelegateCommand subtractMathCommand;
        private DelegateCommand pointMathCommand;
        private DelegateCommand plusMathCommand;
        private DelegateCommand equalMathCommand;

        #region Constructor

        public StandardViewModel()
        {
            calculator = new Models.Calculator();
            memory = new Models.Calculator();
            calcDisplay = "0";
            action = _NO_ACTION;
        }

        #endregion

        public ICommand ExitCommand
        {
            get
            {
                if (exitCommand == null)
                {
                    exitCommand = new DelegateCommand(Exit);
                }
                return exitCommand;
            }
        }
        public ICommand MCMathCommand
        {
            get
            {
                if (mcMathCommand == null)
                {
                    mcMathCommand = new DelegateCommand(MCMathCom);
                }
                return mcMathCommand;
            }
        }
        public ICommand MRMathCommand
        {
            get
            {
                if (mrMathCommand == null)
                {
                    mrMathCommand = new DelegateCommand(MRMathCom);
                }
                return mrMathCommand;
            }
        }
        public ICommand MSMathCommand
        {
            get
            {
                if (msMathCommand == null)
                {
                    msMathCommand = new DelegateCommand(MSMathCom);
                }
                return msMathCommand;
            }
        }
        
        public ICommand MPlusMathCommand
        {
            get
            {
                if (mplusMathCommand == null)
                {
                    mplusMathCommand = new DelegateCommand(MPlusMathCom);
                }
                return mplusMathCommand;
            }
        }
        public ICommand MMinusMathCommand
        {
            get
            {
                if (mminusMathCommand == null)
                {
                    mminusMathCommand = new DelegateCommand(MMinusMathCom);
                }
                return mminusMathCommand;
            }
        }
        public ICommand CEMathCommand
        {
            get
            {
                if (ceMathCommand == null)
                {
                    ceMathCommand = new DelegateCommand(CEMathCom);
                }
                return ceMathCommand;
            }
        }
        public ICommand CMathCommand
        {
            get
            {
                if (cmathCommand == null)
                {
                    cmathCommand = new DelegateCommand(CMathCom);
                }
                return cmathCommand;
            }
        }
        public ICommand MPlusMinusMathCommand
        {
            get
            {
                if (mplusminusMathCommand == null)
                {
                    mplusminusMathCommand = new DelegateCommand(MPlusMinusMathCom);
                }
                return mplusminusMathCommand;
            }
        }
        public ICommand SQRTMathCommand
        {
            get
            {
                if (sqrtMathCommand == null)
                {
                    sqrtMathCommand = new DelegateCommand(SQRTMathCom);
                }
                return sqrtMathCommand;
            }
        }
        public ICommand OneMathCommand
        {
            get
            {
                if (oneMathCommand == null)
                {
                    oneMathCommand = new DelegateCommand(OneMathCom);
                }
                return oneMathCommand;
            }
        }
        public ICommand TwoMathCommand
        {
            get
            {
                if (twoMathCommand == null)
                {
                    twoMathCommand = new DelegateCommand(TwoMathCom);
                }
                return twoMathCommand;
            }
        }
        public ICommand ThreeMathCommand
        {
            get
            {
                if (threeMathCommand == null)
                {
                    threeMathCommand = new DelegateCommand(ThreeMathCom);
                }
                return threeMathCommand;
            }
        }
        public ICommand FourMathCommand
        {
            get
            {
                if (fourMathCommand == null)
                {
                    fourMathCommand = new DelegateCommand(FourMathCom);
                }
                return fourMathCommand;
            }
        }
        public ICommand FiveMathCommand
        {
            get
            {
                if (fiveMathCommand == null)
                {
                    fiveMathCommand = new DelegateCommand(FiveMathCom);
                }
                return fiveMathCommand;
            }
        }
        public ICommand SixMathCommand
        {
            get
            {
                if (sixMathCommand == null)
                {
                    sixMathCommand = new DelegateCommand(SixMathCom);
                }
                return sixMathCommand;
            }
        }
        public ICommand SevenMathCommand
        {
            get
            {
                if (sevenMathCommand == null)
                {
                    sevenMathCommand = new DelegateCommand(SevenMathCom);
                }
                return sevenMathCommand;
            }
        }
        public ICommand EightMathCommand
        {
            get
            {
                if (eightMathCommand == null)
                {
                    eightMathCommand = new DelegateCommand(EightMathCom);
                }
                return eightMathCommand;
            }
        }
        public ICommand NineMathCommand
        {
            get
            {
                if (nineMathCommand == null)
                {
                    nineMathCommand = new DelegateCommand(NineMathCom);
                }
                return nineMathCommand;
            }
        }
        public ICommand ZeroMathCommand
        {
            get
            {
                if (zeroMathCommand == null)
                {
                    zeroMathCommand = new DelegateCommand(ZeroMathCom);
                }
                return zeroMathCommand;
            }
        }
        public ICommand DivMathCommand
        {
            get
            {
                if (divMathCommand == null)
                {
                    divMathCommand = new DelegateCommand(DivMathCom);
                }
                return divMathCommand;
            }
        }
        public ICommand MulMathCommand
        {
            get
            {
                if (mulMathCommand == null)
                {
                    mulMathCommand = new DelegateCommand(MulMathCom);
                }
                return mulMathCommand;
            }
        }
        public ICommand SubtractMathCommand
        {
            get
            {
                if (subtractMathCommand == null)
                {
                    subtractMathCommand = new DelegateCommand(SubtractMathCom);
                }
                return subtractMathCommand;
            }
        }
        public ICommand PointMathCommand
        {
            get
            {
                if (pointMathCommand == null)
                {
                    pointMathCommand = new DelegateCommand(PointMathCom);
                }
                return pointMathCommand;
            }
        }
        public ICommand PlusMathCommand
        {
            get
            {
                if (plusMathCommand == null)
                {
                    plusMathCommand = new DelegateCommand(PlusMathCom);
                }
                return plusMathCommand;
            }
        }
        public ICommand EqualMathCommand
        {
            get
            {
                if (equalMathCommand == null)
                {
                    equalMathCommand = new DelegateCommand(EqualMathCom);
                }
                return equalMathCommand;
            }
        }
        
        private void Exit()
        {
            Application.Current.Shutdown();
        }

        private void MCMathCom()
        {
            memory.Reset();
        }
        private void MRMathCom()
        {
            calcDisplay = memory.GetResult().ToString();
            base.OnPropertyChanged("Sum");
        }
        private void MSMathCom()
        {
            memory.Set(double.Parse(calcDisplay));
        }
        private void MPlusMathCom()
        {
            memory.Add(double.Parse(calcDisplay));
        }
        private void MMinusMathCom()
        {
            memory.Subtract(double.Parse(calcDisplay));
        }
        private void CEMathCom()
        {
            calcDisplay = "0";
            base.OnPropertyChanged("Sum");
        }
        private void CMathCom()
        {
            calculator.Reset();
            calcDisplay = "0";
            base.OnPropertyChanged("Sum");
        }
        private void MPlusMinusMathCom()
        {
            calcDisplay = memory.Inverse(double.Parse(calcDisplay)).ToString();
            base.OnPropertyChanged("Sum");
        }
        private void SQRTMathCom()
        {
            calcDisplay = calculator.SQRT(double.Parse(calcDisplay)).ToString();
            action = _CLEAR;
            base.OnPropertyChanged("Sum");
        }
        private void NumberInsert(string number)
        {
            if (calcDisplay == "0" ||
                action != _NO_ACTION)
            {
                calcDisplay = number;
                action = _NO_ACTION;
            }
            else if (number != "0")
            {
                calcDisplay += number;
            }
            base.OnPropertyChanged("Sum");
        }
        private void OneMathCom()
        {
            NumberInsert("1");
        }
        private void TwoMathCom()
        {
            NumberInsert("2");
        }
        private void ThreeMathCom()
        {
            NumberInsert("3");
        }
        private void FourMathCom()
        {
            NumberInsert("4");
        }
        private void FiveMathCom()
        {
            NumberInsert("5");
        }
        private void SixMathCom()
        {
            NumberInsert("6");
        }
        private void SevenMathCom()
        {
            NumberInsert("7");
        }
        private void EightMathCom()
        {
            NumberInsert("8");
        }
        private void NineMathCom()
        {
            NumberInsert("9");
        }
        private void ZeroMathCom()
        {
            NumberInsert("0");
        }
        private void DivMathCom()
        {
            calcDisplay = runAction().ToString();
            action = _DIVIDE;
        }
        private void MulMathCom()
        {
            calcDisplay = runAction().ToString();
            action = _MULTIPLY;
        }
        private void SubtractMathCom()
        {
            calcDisplay = runAction().ToString();
            action = _SUBTRACT;
        }
        private void PointMathCom()
        {
            if (calcDisplay.Contains('.') == false)
            {
                calcDisplay += ".";
                base.OnPropertyChanged("Sum");
            }
        }
        private void PlusMathCom()
        {
            calcDisplay = runAction().ToString();
            action = _ADD;
        }
        private void EqualMathCom()
        {
            calcDisplay = runAction().ToString();
            calcDisplay = calculator.GetResult().ToString();
            action = _CLEAR;
            base.OnPropertyChanged("Sum");
        }
        private double runAction()
        {
            switch (action)
            {
                case _DIVIDE:
                    calculator.Divide(double.Parse(calcDisplay));
                    calcDisplay = calculator.GetResult().ToString();
                    base.OnPropertyChanged("Sum");
                    break;
                case _MULTIPLY:
                    try
                    {
                        calculator.Multiply(double.Parse(calcDisplay));
                        calcDisplay = calculator.GetResult().ToString();
                        base.OnPropertyChanged("Sum");
                    }
                    catch (DivideByZeroException e)
                    {
                        Models.Logging.append(e.Message, Models.Logging.ALL);
                    }
                    break;
                case _SUBTRACT:
                    calculator.Subtract(double.Parse(calcDisplay));
                    calcDisplay = calculator.GetResult().ToString();
                    base.OnPropertyChanged("Sum");
                    break;
                case _CLEAR:
                    break;
                case _ADD:
                default:
                    calculator.Add(double.Parse(calcDisplay));
                    calcDisplay = calculator.GetResult().ToString();
                    base.OnPropertyChanged("Sum");
                    break;
            }
            return calculator.GetResult();
        }
        public string Sum
        {
            get { return calcDisplay; }
        }
    }
}
