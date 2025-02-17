﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPAreaFinder.Views;
using MVPAreaFinder.Models;

namespace MVPAreaFinder.Presenters
{
    public class FinderPresenter
    {
        IFinder View;

        public FinderPresenter(IFinder view)
        {
            View = view;
        }
        public void CalculateRectangleArea()
        {
            Models.Rectangle rectangle = new Models.Rectangle();
            rectangle.RectWidth = double.Parse(View.rectangleWidthText);
            rectangle.RectHeight = double.Parse(View.rectangleHeightText);

            View.AreaResultText = rectangle.calculateRectangleArea().ToString();
        }

        public void CalculateSquareArea()
        {
            Models.Square square = new Models.Square();
            square.SLength = double.Parse(View.squareLengthText);

            View.AreaResultText = square.CalculateSquareArea().ToString();
        }
    }
}
