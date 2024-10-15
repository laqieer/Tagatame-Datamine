// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.Response.ProductList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.DOM;
using Gsc.Network;
using Gsc.Purchase.API.App;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase.API.Response
{
  [Token(Token = "0x2003625")]
  public class ProductList : GenericResponse<ProductList>
  {
    [Token(Token = "0x17002287")]
    public ProductList.ProductData_t[] Products
    {
      [Token(Token = "0x600F16D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ProductList.ProductData_t[]) null;
      }
      [Token(Token = "0x600F16E"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x600F16F")]
    [Address(RVA = "0xB25230", Offset = "0xB24030", VA = "0x10B25230")]
    public ProductList(WebInternalResponse response)
    {
    }

    [Token(Token = "0x2003626")]
    public class ProductData_t : IResponseObject, Gsc.Network.IObject
    {
      [Token(Token = "0x17002288")]
      public string ProductId
      {
        [Token(Token = "0x600F170"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F171"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x17002289")]
      public float Price
      {
        [Token(Token = "0x600F172"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
        {
          return new float();
        }
        [Token(Token = "0x600F173"), Address(RVA = "0xB24FB0", Offset = "0xB23DB0", VA = "0x10B24FB0")] private set
        {
        }
      }

      [Token(Token = "0x1700228A")]
      public string Name
      {
        [Token(Token = "0x600F174"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F175"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
        {
        }
      }

      [Token(Token = "0x1700228B")]
      public string Currency
      {
        [Token(Token = "0x600F176"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F177"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
        {
        }
      }

      [Token(Token = "0x1700228C")]
      public string LocalizedPrice
      {
        [Token(Token = "0x600F178"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F179"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
        {
        }
      }

      [Token(Token = "0x1700228D")]
      public string Description
      {
        [Token(Token = "0x600F17A"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F17B"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
        {
        }
      }

      [Token(Token = "0x600F17C")]
      [Address(RVA = "0xB24DC0", Offset = "0xB23BC0", VA = "0x10B24DC0")]
      public ProductData_t(IValue node)
      {
      }
    }
  }
}
