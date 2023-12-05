using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using паттерн_Builder.DBCon;
using паттерн_Builder.BuilderBurger;

namespace паттерн_Builder.BuilderBurger
{
    public class BurgerDirector
    {
        private readonly IBurgerBuilder _builder;

        public BurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }

        public void BuildDefault()
        {
            _builder
                .AddCheese()
                .AddTomato()
                .AddPickles();
        }
        public void BuildWithBacon()
        {
            _builder
                .AddTomato()
                .AddBacon()
                .AddLetuce();
        }


    }
}
