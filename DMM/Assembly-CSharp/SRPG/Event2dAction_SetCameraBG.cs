// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_SetCameraBG
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012A7")]
  [EventActionInfo("カメラ/背景イメージを変更(2D)", "カメラの背景イメージを変更します", 5592405, 4473992)]
  public class Event2dAction_SetCameraBG : EventAction
  {
    [Token(Token = "0x400455C")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public Texture2D BackgroundImage;

    [Token(Token = "0x6004F12")]
    [Address(RVA = "0x122CD40", Offset = "0x122BB40", VA = "0x1122CD40", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F13")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_SetCameraBG()
    {
    }
  }
}
