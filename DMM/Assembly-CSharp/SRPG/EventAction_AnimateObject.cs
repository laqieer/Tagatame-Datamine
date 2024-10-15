// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_AnimateObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011EF")]
  [EventActionInfo("オブジェクト/アニメーション (レガシー)", "オブジェクトにアタッチされたアニメーションを再生します。", 5592405, 4473992)]
  public class EventAction_AnimateObject : EventAction
  {
    [Token(Token = "0x400413D")]
    [FieldOffset(Offset = "0x18")]
    public string ObjectID;
    [Token(Token = "0x400413E")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public string AnimationID;

    [Token(Token = "0x6004C40")]
    [Address(RVA = "0x1215F30", Offset = "0x1214D30", VA = "0x11215F30")]
    private static void PlayAnimation(Animation animation, string animationID)
    {
    }

    [Token(Token = "0x6004C41")]
    [Address(RVA = "0x1215CA0", Offset = "0x1214AA0", VA = "0x11215CA0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C42")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public EventAction_AnimateObject()
    {
    }
  }
}
