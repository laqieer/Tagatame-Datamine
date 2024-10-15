// Decompiled with JetBrains decompiler
// Type: SRPG.FixArtifactParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AE5")]
  public class FixArtifactParam
  {
    [Token(Token = "0x40063D5")]
    [FieldOffset(Offset = "0x8")]
    public int StoneOpenMinRare;
    [Token(Token = "0x40063D6")]
    [FieldOffset(Offset = "0xC")]
    public int StoneOpenMinLv;
    [Token(Token = "0x40063D7")]
    [FieldOffset(Offset = "0x10")]
    public int StoneMaterialMinRare;
    [Token(Token = "0x40063D8")]
    [FieldOffset(Offset = "0x14")]
    public int StoneMaterialMinLv;
    [Token(Token = "0x40063D9")]
    [FieldOffset(Offset = "0x18")]
    public int StoneOpenGold;
    [Token(Token = "0x40063DA")]
    [FieldOffset(Offset = "0x1C")]
    public int StoneOpenNeedNum;
    [Token(Token = "0x40063DB")]
    [FieldOffset(Offset = "0x20")]
    public int StoneOpenCommonNeedNum;
    [Token(Token = "0x40063DC")]
    [FieldOffset(Offset = "0x24")]
    public string StoneCommonItem;
    [Token(Token = "0x40063DD")]
    [FieldOffset(Offset = "0x28")]
    public int StoneDrawingGold;
    [Token(Token = "0x40063DE")]
    [FieldOffset(Offset = "0x2C")]
    public int StoneDrawingCost;
    [Token(Token = "0x40063DF")]
    [FieldOffset(Offset = "0x30")]
    public int StoneDrawingCommonCost;
    [Token(Token = "0x40063E0")]
    [FieldOffset(Offset = "0x34")]
    public string StoneConversionItem;
    [Token(Token = "0x40063E1")]
    [FieldOffset(Offset = "0x38")]
    public int[] StoneConversionItemCountList;

    [Token(Token = "0x6006EC2")]
    [Address(RVA = "0x362D30", Offset = "0x361B30", VA = "0x10362D30")]
    public bool Deserialize(JSON_FixArtifactParam json) => new bool();

    [Token(Token = "0x6006EC3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FixArtifactParam()
    {
    }
  }
}
