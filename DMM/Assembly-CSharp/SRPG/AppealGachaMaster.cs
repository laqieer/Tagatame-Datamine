// Decompiled with JetBrains decompiler
// Type: SRPG.AppealGachaMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FC5")]
  public class AppealGachaMaster
  {
    [Token(Token = "0x40086AA")]
    [FieldOffset(Offset = "0x8")]
    public string appeal_id;
    [Token(Token = "0x40086AB")]
    [FieldOffset(Offset = "0x10")]
    public long start_at;
    [Token(Token = "0x40086AC")]
    [FieldOffset(Offset = "0x18")]
    public long end_at;
    [Token(Token = "0x40086AD")]
    [FieldOffset(Offset = "0x20")]
    public bool is_new;

    [Token(Token = "0x60082E5")]
    [Address(RVA = "0x434DC0", Offset = "0x433BC0", VA = "0x10434DC0")]
    public bool Deserialize(JSON_AppealGachaMaster json) => new bool();

    [Token(Token = "0x60082E6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AppealGachaMaster()
    {
    }
  }
}
