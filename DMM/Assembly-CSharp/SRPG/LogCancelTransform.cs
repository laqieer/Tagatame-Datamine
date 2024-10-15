// Decompiled with JetBrains decompiler
// Type: SRPG.LogCancelTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BD4")]
  public class LogCancelTransform : BattleLog
  {
    [Token(Token = "0x4001DFB")]
    [FieldOffset(Offset = "0x8")]
    public Unit self;
    [Token(Token = "0x4001DFC")]
    [FieldOffset(Offset = "0xC")]
    public Unit next_unit;
    [Token(Token = "0x4001DFD")]
    [FieldOffset(Offset = "0x10")]
    public DynamicTransformUnitParam dtu;

    [Token(Token = "0x6002FA0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LogCancelTransform()
    {
    }
  }
}
