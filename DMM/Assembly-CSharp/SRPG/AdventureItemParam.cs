// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200197E")]
  public class AdventureItemParam
  {
    [Token(Token = "0x4005CE0")]
    [FieldOffset(Offset = "0x8")]
    private string mItemIname;
    [Token(Token = "0x4005CE1")]
    [FieldOffset(Offset = "0xC")]
    private ItemParam mItemParam;
    [Token(Token = "0x4005CE2")]
    [FieldOffset(Offset = "0x10")]
    private TimeSpan mReduceMin;

    [Token(Token = "0x17000ABE")]
    public string ItemIname
    {
      [Token(Token = "0x60067F2"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000ABF")]
    public ItemParam ItemParam
    {
      [Token(Token = "0x60067F3"), Address(RVA = "0x31E3E0", Offset = "0x31D1E0", VA = "0x1031E3E0")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17000AC0")]
    public TimeSpan ReduceMin
    {
      [Token(Token = "0x60067F4"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new TimeSpan();
      }
    }

    [Token(Token = "0x60067F5")]
    [Address(RVA = "0x31E100", Offset = "0x31CF00", VA = "0x1031E100")]
    public void Deserialize(JSON_AdventureItemParam json)
    {
    }

    [Token(Token = "0x60067F6")]
    [Address(RVA = "0x31E150", Offset = "0x31CF50", VA = "0x1031E150")]
    public static void Deserialize(
      ref List<AdventureItemParam> list,
      JSON_AdventureItemParam[] json)
    {
    }

    [Token(Token = "0x60067F7")]
    [Address(RVA = "0x31E2D0", Offset = "0x31D0D0", VA = "0x1031E2D0")]
    public static AdventureItemParam GetParam(string item_iname) => (AdventureItemParam) null;

    [Token(Token = "0x60067F8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdventureItemParam()
    {
    }
  }
}
