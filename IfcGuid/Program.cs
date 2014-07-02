using System;

namespace IfcGuid
{
    /// <summary>
    /// Test program
    /// </summary>
  public class Program
  {
    static void Main( string[] args )
    {
      Guid a = Guid.NewGuid();
      Console.WriteLine(".NET GUID: " + a.ToString());
      string ifc_guid = IfcGuid.ToIfcGuid( a );
      Console.WriteLine("IFC GUID: " + ifc_guid);
      Guid b = IfcGuid.FromIfcGuid( ifc_guid );
      Console.WriteLine("Back to .NET GUID: " + b.ToString());
      System.Diagnostics.Debug.Assert(a == b, "GUID does not match");
      Console.ReadKey();
    }
  }
}
