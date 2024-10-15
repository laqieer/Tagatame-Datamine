// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_Scene2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200129F")]
  [EventActionInfo("New/シーン切り替え(2D)", "別シーンに切り替えます", 5592405, 4473992)]
  public class Event2dAction_Scene2 : EventAction_SceneBase
  {
    [Token(Token = "0x4004533")]
    [FieldOffset(Offset = "0x18")]
    [StringIsSceneIDPopup]
    public string SceneID;
    [Token(Token = "0x4004534")]
    [FieldOffset(Offset = "0x1C")]
    private SceneRequest mAsyncOp;
    [Token(Token = "0x4004535")]
    [FieldOffset(Offset = "0x20")]
    private GameObject mSceneRoot;
    [Token(Token = "0x4004536")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public bool FadeIn;
    [Token(Token = "0x4004537")]
    [FieldOffset(Offset = "0x25")]
    [HideInInspector]
    public bool WaitFadeIn;
    [Token(Token = "0x4004538")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public float FadeInTime;

    [Token(Token = "0x6004EE7")]
    [Address(RVA = "0x1242CD0", Offset = "0x1241AD0", VA = "0x11242CD0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EE8")]
    [Address(RVA = "0x1242E90", Offset = "0x1241C90", VA = "0x11242E90")]
    private void OnSceneLoad(GameObject sceneRoot)
    {
    }

    [Token(Token = "0x6004EE9")]
    [Address(RVA = "0x1242FD0", Offset = "0x1241DD0", VA = "0x11242FD0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004EEA")]
    [Address(RVA = "0x1243110", Offset = "0x1241F10", VA = "0x11243110")]
    public Event2dAction_Scene2()
    {
    }
  }
}
