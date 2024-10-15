// Decompiled with JetBrains decompiler
// Type: SRPG.AppealLimitedShopMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FCB")]
  public class AppealLimitedShopMaster
  {
    [Token(Token = "0x40086CB")]
    [FieldOffset(Offset = "0x8")]
    public string appeal_id;
    [Token(Token = "0x40086CC")]
    [FieldOffset(Offset = "0x10")]
    public long start_at;
    [Token(Token = "0x40086CD")]
    [FieldOffset(Offset = "0x18")]
    public long end_at;
    [Token(Token = "0x40086CE")]
    [FieldOffset(Offset = "0x20")]
    public int priority;
    [Token(Token = "0x40086CF")]
    [FieldOffset(Offset = "0x24")]
    public float pos_x_chara;
    [Token(Token = "0x40086D0")]
    [FieldOffset(Offset = "0x28")]
    public float pos_x_text;

    [Token(Token = "0x60082F9")]
    [Address(RVA = "0x438440", Offset = "0x437240", VA = "0x10438440")]
    public bool Deserialize(JSON_AppealLimitedShopMaster json) => new bool();

    [Token(Token = "0x60082FA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AppealLimitedShopMaster()
    {
    }
  }
}
