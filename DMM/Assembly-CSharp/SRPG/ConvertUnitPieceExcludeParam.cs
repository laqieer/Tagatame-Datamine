// Decompiled with JetBrains decompiler
// Type: SRPG.ConvertUnitPieceExcludeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A80")]
  public class ConvertUnitPieceExcludeParam
  {
    [Token(Token = "0x4006204")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4006205")]
    [FieldOffset(Offset = "0xC")]
    public string unit_piece_iname;

    [Token(Token = "0x6006CE0")]
    [Address(RVA = "0x31B680", Offset = "0x31A480", VA = "0x1031B680")]
    public void Deserialize(JSON_ConvertUnitPieceExcludeParam json)
    {
    }

    [Token(Token = "0x6006CE1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConvertUnitPieceExcludeParam()
    {
    }
  }
}
