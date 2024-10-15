// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDedicatedCostParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CEF")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneDedicatedCostParam
  {
    [Token(Token = "0x400715F")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x4007160")]
    [FieldOffset(Offset = "0xC")]
    private int useGold;
    [Token(Token = "0x4007161")]
    [FieldOffset(Offset = "0x10")]
    private int useCoin;
    [Token(Token = "0x4007162")]
    [FieldOffset(Offset = "0x14")]
    private List<RuneDedicatedCostParam.RuneDedicatedCostItemParam> items;

    [Token(Token = "0x17000F7A")]
    [IgnoreMember]
    public string Iname
    {
      [Token(Token = "0x60076CF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F7B")]
    [IgnoreMember]
    public int UseGold
    {
      [Token(Token = "0x60076D0"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F7C")]
    [IgnoreMember]
    public int UseCoin
    {
      [Token(Token = "0x60076D1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F7D")]
    [IgnoreMember]
    public List<RuneDedicatedCostParam.RuneDedicatedCostItemParam> Items
    {
      [Token(Token = "0x60076D2"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<RuneDedicatedCostParam.RuneDedicatedCostItemParam>) null;
      }
    }

    [Token(Token = "0x60076D3")]
    [Address(RVA = "0x398770", Offset = "0x397570", VA = "0x10398770")]
    public bool Deserialize(JSON_RuneDedicatedCost json) => new bool();

    [Token(Token = "0x60076D4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneDedicatedCostParam()
    {
    }

    [Token(Token = "0x2001CF0")]
    [MessagePackObject(true)]
    [Serializable]
    public class RuneDedicatedCostItemParam
    {
      [Token(Token = "0x4007163")]
      [FieldOffset(Offset = "0x8")]
      private string iname;
      [Token(Token = "0x4007164")]
      [FieldOffset(Offset = "0xC")]
      private int num;

      [Token(Token = "0x17000F7E")]
      [IgnoreMember]
      public string Iname
      {
        [Token(Token = "0x60076D5"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000F7F")]
      [IgnoreMember]
      public int Num
      {
        [Token(Token = "0x60076D6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x60076D7")]
      [Address(RVA = "0x372170", Offset = "0x370F70", VA = "0x10372170")]
      public bool Deserialize(JSON_RuneDedicatedCostItem json) => new bool();

      [Token(Token = "0x60076D8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RuneDedicatedCostItemParam()
      {
      }
    }
  }
}
