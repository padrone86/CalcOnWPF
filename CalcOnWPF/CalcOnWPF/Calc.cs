using Prism.Mvvm;

namespace CalcOnWPF
{
    public class Calc : BindableBase
    {
        int _num1;
        int _num2;

        /// <summary>
        /// 足される数
        /// </summary>
        public int Num1
        {
            get { return _num1; }
            set
            {
                SetProperty(ref _num1, value);
                RaisePropertyChanged(nameof(Sum));
            }
        }

        /// <summary>
        /// 足す数
        /// </summary>
        public int Num2
        {
            get { return _num2; }
            set
            {
                SetProperty(ref _num2, value);
                RaisePropertyChanged(nameof(Sum));
            }
        }

        /// <summary>
        /// 合計
        /// </summary>
        public int Sum { get { return Num1 + Num2; } }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Calc()
        {
            Num1 = 0;
            Num2 = 0;
        }
    }
}
