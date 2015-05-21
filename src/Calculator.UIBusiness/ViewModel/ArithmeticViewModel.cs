using System;
using System.ComponentModel;
using Calculator.UIBusiness.Model;

namespace Calculator.UIBusiness.ViewModel
{
    /// <summary>
    /// Stores the last operation performed
    /// </summary>
    public enum LastOperation
    {
        None, Add, Subtract, Multiply, Divide
    };

    /// <summary>
    /// View model
    /// </summary>
    public class ArithmeticViewModel : INotifyPropertyChanged
    {
        #region Event Declarations

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion Event Declarations

        #region Fields

        private ArithmeticModel model;

        #endregion Fields

        #region Properties

        public ArithmeticModel Model
        {
            get { return model; }
            set
            {
                model = value;

                RaisePropertyChanged("Model");
            }
        }

        public double UpdateNumber
        {
            get { return Model.Number; }
            set
            {
                if (Model.Number == 0)
                    Model.Number = value;

                else if (BNewEntry)
                {
                    Model.Number = value;
                    BNewEntry = false;
                }
                else
                    Model.Number = double.Parse(Model.Number.ToString() + value.ToString());

                RaisePropertyChanged("updateNumber");
            }
        }

        public double TempNumber { get; set; }
        public bool BNewEntry { get; set; }
        public LastOperation LastOperation { get; set; }

        #endregion Properties

        #region Constructors

        public ArithmeticViewModel()
        {
            Model = new ArithmeticModel();
            TempNumber = 0;
            LastOperation = LastOperation.None;
            BNewEntry = false;
        }

        #endregion Constructors

        #region Commands

        public void RunAdd()
        {
            if (LastOperation == LastOperation.Add)
            {
                double sum = Model.add(UpdateNumber, TempNumber);
                RunClear();
                UpdateNumber = sum;
            }
            TempNumber = UpdateNumber;
            BNewEntry = true;

            LastOperation = LastOperation.Add;
        }

        public void RunSubtract()
        {

            if (LastOperation == LastOperation.Subtract)
            {
                double sum = Model.subtract(TempNumber, UpdateNumber);
                RunClear();
                UpdateNumber = sum;
            }
            TempNumber = UpdateNumber;
            BNewEntry = true;
            LastOperation = LastOperation.Subtract;
        }

        public void RunMultiply()
        {
            if (LastOperation == LastOperation.Multiply)
            {
                double sum = Model.Multiply(TempNumber, UpdateNumber);
                RunClear();
                UpdateNumber = sum;
            }
            TempNumber = UpdateNumber;
            BNewEntry = true;
            LastOperation = LastOperation.Multiply;
        }

        public void RunDivide()
        {
            if (LastOperation == LastOperation.Divide)
            {
                double sum = Model.Divide(TempNumber, UpdateNumber);
                RunClear();
                UpdateNumber = sum;
            }
            TempNumber = UpdateNumber;
            BNewEntry = true;
            LastOperation = LastOperation.Divide;
        }

        public void RunClear()
        {
            Model.Number = 0;
            UpdateNumber = 0;
        }

        public void RunClearAll()
        {
            Model.Number = 0;
            UpdateNumber = 0;
            TempNumber = 0;
            BNewEntry = false;
            LastOperation = LastOperation.None;
        }

        public void RunEquals()
        {
            if (LastOperation == LastOperation.Add)
                RunAdd();
            else if (LastOperation == LastOperation.Multiply)
                RunMultiply();
            else if (LastOperation == LastOperation.Divide)
                RunDivide();
            else if (LastOperation == LastOperation.Subtract)
                RunSubtract();

            LastOperation = LastOperation.None;
        }

        #endregion Commands
    }
}
