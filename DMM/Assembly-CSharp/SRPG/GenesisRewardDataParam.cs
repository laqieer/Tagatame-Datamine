// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisRewardDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B11")]
  public class GenesisRewardDataParam
  {
    [Token(Token = "0x4006734")]
    [FieldOffset(Offset = "0x8")]
    public int ItemType;
    [Token(Token = "0x4006735")]
    [FieldOffset(Offset = "0xC")]
    public string ItemIname;
    [Token(Token = "0x4006736")]
    [FieldOffset(Offset = "0x10")]
    public int ItemNum;

    [Token(Token = "0x6006FC3")]
    [Address(RVA = "0x31AF60", Offset = "0x319D60", VA = "0x1031AF60")]
    public void Deserialize(JSON_GenesisRewardDataParam json)
    {
    }

    [Token(Token = "0x6006FC4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GenesisRewardDataParam()
    {
    }
  }
}
