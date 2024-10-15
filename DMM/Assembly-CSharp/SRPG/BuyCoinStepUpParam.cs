// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinStepUpParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019C8")]
  public class BuyCoinStepUpParam
  {
    [Token(Token = "0x4005EC5")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005EC6")]
    [FieldOffset(Offset = "0xC")]
    public string shop_id;
    [Token(Token = "0x4005EC7")]
    [FieldOffset(Offset = "0x10")]
    public int is_day_reset;
    [Token(Token = "0x4005EC8")]
    [FieldOffset(Offset = "0x14")]
    public int is_platform_common;
    [Token(Token = "0x4005EC9")]
    [FieldOffset(Offset = "0x18")]
    public int unlock_lv;
    [Token(Token = "0x4005ECA")]
    [FieldOffset(Offset = "0x1C")]
    public List<BuyCoinStepUpParam.BuyCoinStepUpProductListParam> products;

    [Token(Token = "0x6006920")]
    [Address(RVA = "0x34F8C0", Offset = "0x34E6C0", VA = "0x1034F8C0")]
    public bool Deserialize(JSON_BuyCoinStepUpParam json) => new bool();

    [Token(Token = "0x6006921")]
    [Address(RVA = "0x34FA90", Offset = "0x34E890", VA = "0x1034FA90")]
    public static void Deserialize(
      ref List<BuyCoinStepUpParam> ref_params,
      JSON_BuyCoinStepUpParam[] json)
    {
    }

    [Token(Token = "0x6006922")]
    [Address(RVA = "0x34FBC0", Offset = "0x34E9C0", VA = "0x1034FBC0")]
    public static BuyCoinStepUpParam GetBuyCoinStepUpParam(string iname)
    {
      return (BuyCoinStepUpParam) null;
    }

    [Token(Token = "0x6006923")]
    [Address(RVA = "0x34F4A0", Offset = "0x34E2A0", VA = "0x1034F4A0")]
    public static void AddBuyCoinProductByBuyCoinStepUp()
    {
    }

    [Token(Token = "0x6006924")]
    [Address(RVA = "0x34F5A0", Offset = "0x34E3A0", VA = "0x1034F5A0")]
    private static BuyCoinStepUpProductParent CreateStepUpProductParentByStepUp(
      BuyCoinStepUpParam _stepup)
    {
      return (BuyCoinStepUpProductParent) null;
    }

    [Token(Token = "0x6006925")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuyCoinStepUpParam()
    {
    }

    [Token(Token = "0x20019C9")]
    public class BuyCoinStepUpProductListParam
    {
      [Token(Token = "0x4005ECB")]
      [FieldOffset(Offset = "0x8")]
      public string product_id;
      [Token(Token = "0x4005ECC")]
      [FieldOffset(Offset = "0xC")]
      public string reward;
      [Token(Token = "0x4005ECD")]
      [FieldOffset(Offset = "0x10")]
      public string title;
      [Token(Token = "0x4005ECE")]
      [FieldOffset(Offset = "0x14")]
      public string description;
      [Token(Token = "0x4005ECF")]
      [FieldOffset(Offset = "0x18")]
      public int badge;
      [Token(Token = "0x4005ED0")]
      [FieldOffset(Offset = "0x1C")]
      public int img_array_idx;
      [Token(Token = "0x4005ED1")]
      [FieldOffset(Offset = "0x20")]
      public string temp_name;
      [Token(Token = "0x4005ED2")]
      [FieldOffset(Offset = "0x24")]
      public string expr;

      [Token(Token = "0x6006926")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BuyCoinStepUpProductListParam()
      {
      }
    }
  }
}
