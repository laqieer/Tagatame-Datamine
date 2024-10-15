// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ArenaPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E4D")]
  public class Json_ArenaPlayer
  {
    [Token(Token = "0x4002B7E")]
    [FieldOffset(Offset = "0x8")]
    public string result;
    [Token(Token = "0x4002B7F")]
    [FieldOffset(Offset = "0xC")]
    public string fuid;
    [Token(Token = "0x4002B80")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4002B81")]
    [FieldOffset(Offset = "0x14")]
    public int lv;
    [Token(Token = "0x4002B82")]
    [FieldOffset(Offset = "0x18")]
    public int rank;
    [Token(Token = "0x4002B83")]
    [FieldOffset(Offset = "0x1C")]
    public Json_Unit[] units;
    [Token(Token = "0x4002B84")]
    [FieldOffset(Offset = "0x20")]
    public long btl_at;
    [Token(Token = "0x4002B85")]
    [FieldOffset(Offset = "0x28")]
    public string award;
    [Token(Token = "0x4002B86")]
    [FieldOffset(Offset = "0x2C")]
    public JSON_ViewGuild guild;

    [Token(Token = "0x6003AFE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ArenaPlayer()
    {
    }
  }
}
