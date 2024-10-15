// Decompiled with JetBrains decompiler
// Type: SRPG.RuneEnforceGaugeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010F4")]
  public class RuneEnforceGaugeData
  {
    [Token(Token = "0x4003D3C")]
    [FieldOffset(Offset = "0x8")]
    public byte rare;
    [Token(Token = "0x4003D3D")]
    [FieldOffset(Offset = "0xA")]
    public short val;

    [Token(Token = "0x60047A0")]
    [Address(RVA = "0x11F14F0", Offset = "0x11F02F0", VA = "0x111F14F0")]
    public bool Deserialize(Json_RuneEnforceGaugeData json) => new bool();

    [Token(Token = "0x60047A1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneEnforceGaugeData()
    {
    }
  }
}
