// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SetBackground
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001237")]
  [EventActionInfo("カメラ/背景イメージを変更", "カメラの背景イメージを変更します", 5592405, 4473992)]
  public class EventAction_SetBackground : EventAction
  {
    [Token(Token = "0x4004302")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public Texture2D BackgroundImage;

    [Token(Token = "0x6004D29")]
    [Address(RVA = "0x122F7D0", Offset = "0x122E5D0", VA = "0x1122F7D0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D2A")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public EventAction_SetBackground()
    {
    }
  }
}
