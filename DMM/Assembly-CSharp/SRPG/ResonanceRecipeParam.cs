// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceRecipeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CC2")]
  [MessagePackObject(true)]
  public class ResonanceRecipeParam
  {
    [Token(Token = "0x40070CF")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40070D0")]
    [FieldOffset(Offset = "0xC")]
    private ResonanceUseItemParam[] mItems;

    [Token(Token = "0x17000F5F")]
    public string Iname
    {
      [Token(Token = "0x6007651"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F60")]
    public ResonanceUseItemParam[] Items
    {
      [Token(Token = "0x6007652"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ResonanceUseItemParam[]) null;
      }
    }

    [Token(Token = "0x6007653")]
    [Address(RVA = "0x397E40", Offset = "0x396C40", VA = "0x10397E40")]
    public bool Deserialize(JSON_ResonanceRecipeParam json) => new bool();

    [Token(Token = "0x6007654")]
    [Address(RVA = "0x397BC0", Offset = "0x3969C0", VA = "0x10397BC0")]
    public static bool Deserialize(
      ref List<ResonanceRecipeParam> paramList,
      JSON_ResonanceRecipeParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6007655")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ResonanceRecipeParam()
    {
    }
  }
}
