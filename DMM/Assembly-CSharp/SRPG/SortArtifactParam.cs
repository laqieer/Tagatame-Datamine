// Decompiled with JetBrains decompiler
// Type: SRPG.SortArtifactParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D49")]
  public class SortArtifactParam
  {
    [Token(Token = "0x17000FE0")]
    public string Iname
    {
      [Token(Token = "0x60077F5"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60077F6"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000FE1")]
    public string TabName
    {
      [Token(Token = "0x60077F7"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60077F8"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000FE2")]
    public string ItemName
    {
      [Token(Token = "0x60077F9"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60077FA"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000FE3")]
    public string SubItemName
    {
      [Token(Token = "0x60077FB"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60077FC"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17000FE4")]
    public List<SortArtifactCondParam> Conditions
    {
      [Token(Token = "0x60077FD"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<SortArtifactCondParam>) null;
      }
      [Token(Token = "0x60077FE"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x60077FF")]
    [Address(RVA = "0x39FD40", Offset = "0x39EB40", VA = "0x1039FD40")]
    public bool Deserialize(JSON_SortArtifactParam json) => new bool();

    [Token(Token = "0x6007800")]
    [Address(RVA = "0x39FC40", Offset = "0x39EA40", VA = "0x1039FC40")]
    public static void Deserialize(ref List<SortArtifactParam> param, JSON_SortArtifactParam[] json)
    {
    }

    [Token(Token = "0x6007801")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SortArtifactParam()
    {
    }
  }
}
