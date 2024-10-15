// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.TargetState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032EE")]
  public class TargetState : AnimEvent
  {
    [Token(Token = "0x400EFB6")]
    [FieldOffset(Offset = "0x18")]
    public TargetState.StateTypes State;

    [Token(Token = "0x600DFA7")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public TargetState()
    {
    }

    [Token(Token = "0x20032EF")]
    public enum StateTypes
    {
      [Token(Token = "0x400EFB8")] Stand,
      [Token(Token = "0x400EFB9")] Down,
      [Token(Token = "0x400EFBA")] Kirimomi,
    }
  }
}
