// Decompiled with JetBrains decompiler
// Type: SRPG.AppealEventShopMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FC0")]
  public class AppealEventShopMaster
  {
    [Token(Token = "0x4008690")]
    [FieldOffset(Offset = "0x8")]
    public string appeal_id;
    [Token(Token = "0x4008691")]
    [FieldOffset(Offset = "0x10")]
    public long start_at;
    [Token(Token = "0x4008692")]
    [FieldOffset(Offset = "0x18")]
    public long end_at;
    [Token(Token = "0x4008693")]
    [FieldOffset(Offset = "0x20")]
    public int priority;
    [Token(Token = "0x4008694")]
    [FieldOffset(Offset = "0x24")]
    public float position_chara;
    [Token(Token = "0x4008695")]
    [FieldOffset(Offset = "0x28")]
    public float position_text;

    [Token(Token = "0x60082D4")]
    [Address(RVA = "0x434CA0", Offset = "0x433AA0", VA = "0x10434CA0")]
    public bool Deserialize(JSON_AppealEventShopMaster json) => new bool();

    [Token(Token = "0x60082D5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AppealEventShopMaster()
    {
    }
  }
}
