// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_Scene2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001232")]
  [EventActionInfo("New/シーン切り替え", "別シーンに切り替えます", 5592405, 4473992)]
  public class EventAction_Scene2 : EventAction_SceneBase
  {
    [Token(Token = "0x40042EB")]
    [FieldOffset(Offset = "0x18")]
    [StringIsSceneIDPopup]
    public string SceneID;
    [Token(Token = "0x40042EC")]
    [FieldOffset(Offset = "0x1C")]
    private SceneRequest mAsyncOp;
    [Token(Token = "0x40042ED")]
    [FieldOffset(Offset = "0x20")]
    private GameObject mSceneRoot;
    [Token(Token = "0x40042EE")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public bool FadeIn;
    [Token(Token = "0x40042EF")]
    [FieldOffset(Offset = "0x25")]
    [HideInInspector]
    public bool WaitFadeIn;
    [Token(Token = "0x40042F0")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public float FadeInTime;
    [Token(Token = "0x40042F1")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public List<GameObject> SceneObject;

    [Token(Token = "0x6004D1F")]
    [Address(RVA = "0x122EBA0", Offset = "0x122D9A0", VA = "0x1122EBA0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D20")]
    [Address(RVA = "0x122ED60", Offset = "0x122DB60", VA = "0x1122ED60")]
    private void OnSceneLoad(GameObject sceneRoot)
    {
    }

    [Token(Token = "0x6004D21")]
    [Address(RVA = "0x122EE90", Offset = "0x122DC90", VA = "0x1122EE90", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004D22")]
    [Address(RVA = "0x122EFD0", Offset = "0x122DDD0", VA = "0x1122EFD0")]
    public EventAction_Scene2()
    {
    }
  }
}
