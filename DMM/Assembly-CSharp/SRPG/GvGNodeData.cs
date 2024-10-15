// Decompiled with JetBrains decompiler
// Type: SRPG.GvGNodeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025B8")]
  public class GvGNodeData
  {
    [Token(Token = "0x1700176E")]
    public int UniqueId
    {
      [Token(Token = "0x600A760"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A761"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x1700176F")]
    public int NodeId
    {
      [Token(Token = "0x600A762"), Address(RVA = "0x3DA4C0", Offset = "0x3D92C0", VA = "0x103DA4C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001770")]
    public GvGNodeParam NodeParam
    {
      [Token(Token = "0x600A763"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (GvGNodeParam) null;
      }
      [Token(Token = "0x600A764"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001771")]
    public GvGNodeState State
    {
      [Token(Token = "0x600A765"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new GvGNodeState();
      }
      [Token(Token = "0x600A766"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x17001772")]
    public int GuildId
    {
      [Token(Token = "0x600A767"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x600A768"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17001773")]
    public int DeclaredGuildId
    {
      [Token(Token = "0x600A769"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
      [Token(Token = "0x600A76A"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x17001774")]
    public DateTime CaptureTime
    {
      [Token(Token = "0x600A76B"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600A76C"), Address(RVA = "0x34D360", Offset = "0x34C160", VA = "0x1034D360")] private set
      {
      }
    }

    [Token(Token = "0x17001775")]
    public DateTime AttackEnableTime
    {
      [Token(Token = "0x600A76D"), Address(RVA = "0x31F950", Offset = "0x31E750", VA = "0x1031F950")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600A76E"), Address(RVA = "0x305820", Offset = "0x304620", VA = "0x10305820")] private set
      {
      }
    }

    [Token(Token = "0x17001776")]
    public int DefensePartyNum
    {
      [Token(Token = "0x600A76F"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A770"), Address(RVA = "0x373930", Offset = "0x372730", VA = "0x10373930")] private set
      {
      }
    }

    [Token(Token = "0x17001777")]
    public bool CanDeclare
    {
      [Token(Token = "0x600A771"), Address(RVA = "0x691990", Offset = "0x690790", VA = "0x10691990")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001778")]
    public bool IsAttackWait
    {
      [Token(Token = "0x600A772"), Address(RVA = "0x6919B0", Offset = "0x6907B0", VA = "0x106919B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A773")]
    [Address(RVA = "0x691890", Offset = "0x690690", VA = "0x10691890")]
    public bool Deserialize(JSON_GvGNodeData json) => new bool();

    [Token(Token = "0x600A774")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GvGNodeData()
    {
    }
  }
}
