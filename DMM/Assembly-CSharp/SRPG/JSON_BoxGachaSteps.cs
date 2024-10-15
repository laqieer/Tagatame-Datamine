// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_BoxGachaSteps
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020FE")]
  [Serializable]
  public class JSON_BoxGachaSteps
  {
    [Token(Token = "0x4008EB6")]
    [FieldOffset(Offset = "0x8")]
    public int step;
    [Token(Token = "0x4008EB7")]
    [FieldOffset(Offset = "0xC")]
    public int total_num;
    [Token(Token = "0x4008EB8")]
    [FieldOffset(Offset = "0x10")]
    public int total_num_feature;
    [Token(Token = "0x4008EB9")]
    [FieldOffset(Offset = "0x14")]
    public int total_num_normal;
    [Token(Token = "0x4008EBA")]
    [FieldOffset(Offset = "0x18")]
    public int remain_num_feature;
    [Token(Token = "0x4008EBB")]
    [FieldOffset(Offset = "0x1C")]
    public int remain_num_normal;
    [Token(Token = "0x4008EBC")]
    [FieldOffset(Offset = "0x20")]
    public JSON_BoxGachaItems[] box_items;

    [Token(Token = "0x60089E6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_BoxGachaSteps()
    {
    }
  }
}
