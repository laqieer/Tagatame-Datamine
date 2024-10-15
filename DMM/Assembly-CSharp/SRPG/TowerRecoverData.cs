// Decompiled with JetBrains decompiler
// Type: SRPG.TowerRecoverData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015BC")]
  public class TowerRecoverData
  {
    [Token(Token = "0x4004F1B")]
    [FieldOffset(Offset = "0x8")]
    public string towerID;
    [Token(Token = "0x4004F1C")]
    [FieldOffset(Offset = "0xC")]
    public int useCoin;

    [Token(Token = "0x6005973")]
    [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
    public TowerRecoverData(string towerID, int useCoin)
    {
    }
  }
}
