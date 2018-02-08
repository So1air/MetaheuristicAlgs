using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalOptimization
{
    enum TypeConicCurve
    { 
        Ellipse, 
        Hyperbola, 
        Parabola, 
        Point, 
        ConcurrentStraights, 
        ParallelStraights, 
        Straight, 
        ImaginaryEllipse, 
        ImaginaryParallelStraights 
    }

    struct Interval
    {
        public readonly double Low;
        public readonly double High;

        public Interval(double l, double h)
        {
            if (l <= h)
            {
                Low = l;
                High = h;
            }
            else
            {
                Low = h;
                High = l;
            }
        }
    }

    struct OneDimFuncWithDefArea
    {
        public readonly Func<double, double> F;
        public readonly Interval[] Areas;

        public OneDimFuncWithDefArea(Func<double, double> f, params Interval[] areas)
        {
            F = f;
            Areas = areas;
        }
    }

    class CurveOfSecondOrder
    {
        double _a11, _a12, _a22, _a13, _a23, _a33;

        public double A11
        {
            get { return _a11; }
            set 
            {
                if ((value == 0) && (_a12 == 0) && (_a22 == 0))
                    return;

                _a11 = value; 
            }
        }

        public double A12
        {
            get { return _a12; }
            set 
            {
                if ((_a11 == 0) && (value == 0) && (_a22 == 0))
                    return;

                _a12 = value; 
            }
        }

        public double A22
        {
            get { return _a22; }
            set 
            {
                if ((_a11 == 0) && (_a12 == 0) && (value == 0))
                    return;

                _a22 = value; 
            }
        }

        public double A13
        {
            get { return _a13; }
            set { _a13 = value; }
        }

        public double A23
        {
            get { return _a23; }
            set { _a23 = value; }
        }

        public double A33
        {
            get { return _a33; }
            set { _a33 = value; }
        }

        public double I1
        {
            get { return _a11 + _a22; }
        }

        public double I2
        {
            get { return _a11 * _a22 - _a12 * _a12; }
        }

        public double I3
        {
            get { return _a11 * _a22 * _a33 + 2d * _a12 * _a23 * _a13 - _a13 * _a22 * _a13 - _a12 * _a12 * _a33 - _a23 * _a23 * _a11; }
        }

        public TypeConicCurve Type
        {
            get
            {
                double I = this.I1,
                       D = this.I2,
                       det = this.I3;
                if (D > 0)
                    if (det < 0)
                        return TypeConicCurve.Ellipse;
                    else
                        if (det == 0)
                            return TypeConicCurve.Point;
                        else
                            return TypeConicCurve.ImaginaryEllipse;
                else
                    if (D == 0)
                        if (det != 0)
                            return TypeConicCurve.Parabola;
                        else
                            if (I * _a33 < 0)
                                return TypeConicCurve.ImaginaryParallelStraights;
                            else
                                if (_a33 == 0)
                                    return TypeConicCurve.Straight;
                                else
                                    return TypeConicCurve.ParallelStraights;
                    else
                        if (det != 0)
                            return TypeConicCurve.Hyperbola;
                        else
                            return TypeConicCurve.ConcurrentStraights;                   
            }    
        }

        public bool IsCentral
        {
            get { return (this.I2 != 0); }
        }

        public bool IsCanonymic
        {
            get { return (_a12 == 0) && (_a13 == 0) && (_a23 == 0); }
        }

        public static CurveOfSecondOrder operator -(CurveOfSecondOrder curve)
        {
            return new CurveOfSecondOrder(-curve._a11, -curve._a12, -curve._a22, -curve._a13, -curve._a23, -curve._a33);
        }

        public static CurveOfSecondOrder operator *(double a, CurveOfSecondOrder curve)
        {
            return new CurveOfSecondOrder(a * curve._a11, a * curve._a12, a * curve._a22, a * curve._a13, a * curve._a23, a * curve._a33);
        }

        public CurveOfSecondOrder NormalizeForm
        {
            get { return (_a33 != 0) ? (-1d / _a33) * this : this.Clone(); }
        }

        public CurveOfSecondOrder CanonymicForm
        {
            get 
            {
                if (this.IsCanonymic)
                    return this.Clone();
                
                if (this.IsCentral)
                    if (_a12 == 0)
                        return new CurveOfSecondOrder(_a11, 0d, _a22, 0d, 0d, this.I3 / this.I2).NormalizeForm;
                    else
                    {
                        double _2phee = (_a11 != _a22) ? Math.Atan((2d * _a12) / (_a11 - _a22)) : 0.5 * Math.PI * Math.Sign(_a12);
                        return new CurveOfSecondOrder(_a12 * Math.Sin(_2phee) + 0.5 * (_a11 - _a22) * Math.Cos(_2phee) + 0.5 * (_a11 + _a22),
                                                      0d,
                                                      -_a12 * Math.Sin(_2phee) - 0.5 * (_a11 - _a22) * Math.Cos(_2phee) + 0.5 * (_a11 + _a22),
                                                      0d,
                                                      0d,
                                                      this.I3 / this.I2).NormalizeForm;
                    }
                else
                {
                    CurveOfSecondOrder tmp;
                    if (_a12 != 0)
                        tmp = this.Rotate((_a11 != _a22) ? Math.Atan((2d * _a12) / (_a11 - _a22)) * 0.5 : 0.25 * Math.PI * Math.Sign(_a12));
                    else
                        tmp = this;

                    if (tmp.A11 == 0)
                        return tmp.СoordinateTranslation(0d, tmp.A23 / this.I1).NormalizeForm;
                    else
                        return tmp.СoordinateTranslation(tmp.A13 / this.I1, 0d).NormalizeForm;
                }
            }
        }

        public double AngleOfObliquity//?
        {
            get
            {
                return (_a12 == 0) ? 0 : ((_a11 != _a22) ? Math.Atan((2d * _a12) / (_a11 - _a22)) * 0.5 : 0.25 * Math.PI * Math.Sign(_a12));//??????
            }
        }

        public double[] GetCenter()//+
        {
            return (IsCentral) ? new double[2] {(_a12 * _a23 - _a22 * _a13) / this.I2, (_a12 * _a13 - _a11 * _a23) / this.I2} : new double[2] {double.NaN, double.NaN};
        }

        public CurveOfSecondOrder Rotate(double phee)//+
        {
            double sin2phee = Math.Sin(2 * phee),
                   cos2phee = Math.Cos(2 * phee),
                   sinphee = Math.Sin(phee),
                   cosphee = Math.Cos(phee),
                   a11_a22 = _a11 - _a22,
                   a11_4_a22 = _a11 + _a22;
            return new CurveOfSecondOrder(_a12 * sin2phee + 0.5 * a11_a22 * cos2phee + 0.5 * a11_4_a22,
                                          -0.5 * a11_a22 * sin2phee + _a12 * cos2phee,
                                          -_a12 * sin2phee - 0.5 * a11_a22 * cos2phee + 0.5 * a11_4_a22,
                                          _a13 * cosphee + _a23 * sinphee,
                                          _a23 * cosphee - _a13 * sinphee,
                                          _a33);
        }

        public CurveOfSecondOrder СoordinateTranslation(double x0, double y0)//+
        {
            double a_13, a_23;
            return new CurveOfSecondOrder(_a11, _a12, _a22, 
                                   a_13 = _a11 * x0 + _a12 * y0 + _a13, 
                                   a_23 = _a12 * x0 + _a22 * y0 + _a23, 
                                          (a_13 + _a13) * x0 + (a_23 + _a23) * y0 + _a33);  
        }

        //public List<OneDimFuncWithDefArea> FunctionalSeparation
        //{
        //    get
        //    {
        //        //???????
        //    }
        //}

        public Func<double, double[]> PolarFunctional//+
        {
            get
            {                
                double[] centr;
                switch (this.Type)
                {
                    case TypeConicCurve.Ellipse:
                        centr = this.GetCenter();
                        double a33central = _a13 * centr[0] + _a23 * centr[1] + _a33;
                        double ang = Math.PI / 2d - 2 * this.AngleOfObliquity;   //магія, не знаю чому, але працює
                        return (teta) =>
                        {
                            double r = Math.Sqrt(-a33central / (_a11 * Math.Pow(Math.Sin(teta + ang), 2) + 2 *_a12 * Math.Sin(teta + ang) * Math.Cos(teta + ang) + _a22 * Math.Pow(Math.Cos(teta + ang), 2)));
                            return new double[2] { r * Math.Cos(teta) + centr[0], r * Math.Sin(teta) + centr[1] };
                        };

                    case TypeConicCurve.Point:
                        centr = this.GetCenter();
                        return (teta) => (centr);
                    default:
                        return (teta) => (new double[2] { double.NaN, double.NaN }); //??????????????????????? 
                }
            }
        }

        public CurveOfSecondOrder Clone()
        {
            return new CurveOfSecondOrder(_a11, _a12, _a22, _a13, _a23, _a33);
        }

        public CurveOfSecondOrder(double a11, double a12, double a22, double a13, double a23, double a33)
        {
            if ((a11 == 0) && (a12 == 0) && (a22 == 0))
                throw new ArgumentException();

            _a11 = a11;
            _a12 = a12;
            _a22 = a22; 
            _a13 = a13;
            _a23 = a23;
            _a33 = a33;
        }
    }
}
