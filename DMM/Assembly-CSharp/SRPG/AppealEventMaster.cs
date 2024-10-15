// Decompiled with JetBrains decompiler
// Type: SRPG.AppealEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FBA")]
  public class AppealEventMaster
  {
    [Token(Token = "0x4008672")]
    [FieldOffset(Offset = "0x8")]
    public string appeal_id;
    [Token(Token = "0x4008673")]
    [FieldOffset(Offset = "0x10")]
    public long start_at;
    [Token(Token = "0x4008674")]
    [FieldOffset(Offset = "0x18")]
    public long end_at;

    [Token(Token = "0x60082C1")]
    [Address(RVA = "0x434BB0", Offset = "0x4339B0", VA = "0x10434BB0")]
    public bool Deserialize(JSON_AppealEventMaster json) => new bool();

    [Token(Token = "0x60082C2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AppealEventMaster()
    {
    }
  }
}
