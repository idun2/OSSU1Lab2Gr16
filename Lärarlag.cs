using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering
{


interface ILararlag
{
    int lararlagID { get; set; }
    string larare { get; set; }

}

class Lararlag : ILararlag
{
    #region Lärarlag

    public int lararlagID
    {
        get { return lararlagID; }
        set { lararlagID = value; }
    }


    public string larare
    {
        get { return larare; }
        set { larare = value; }

    }
    #endregion
}



}
