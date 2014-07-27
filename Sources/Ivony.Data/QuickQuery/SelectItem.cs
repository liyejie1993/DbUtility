﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivony.Data.QuickQuery
{
  public class SelectItem
  {


    public SelectItem( ValueExpression expression, string alias = null )
    {
      Expression = expression;
      Alias = alias;
    }


    public ValueExpression Expression { get; private set; }

    public string Alias { get; private set; }

  }
}