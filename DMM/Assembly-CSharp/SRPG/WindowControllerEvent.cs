// Decompiled with JetBrains decompiler
// Type: SRPG.WindowControllerEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D37")]
  public class WindowControllerEvent : StateMachineBehaviour
  {
    [Token(Token = "0x400E16C")]
    [FieldOffset(Offset = "0xC")]
    public WindowControllerEvent.EventTypes Type;

    [Token(Token = "0x600D2C3")]
    [Address(RVA = "0x9E0C90", Offset = "0x9DFA90", VA = "0x109E0C90", Slot = "4")]
    public override void OnStateEnter(
      Animator animator,
      AnimatorStateInfo stateInfo,
      int layerIndex)
    {
    }

    [Token(Token = "0x600D2C4")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public WindowControllerEvent()
    {
    }

    [Token(Token = "0x2002D38")]
    public enum EventTypes
    {
      [Token(Token = "0x400E16E")] Opened,
      [Token(Token = "0x400E16F")] Closed,
    }
  }
}
