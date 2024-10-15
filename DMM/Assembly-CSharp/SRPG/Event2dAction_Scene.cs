// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_Scene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200129E")]
  [EventActionInfo("シーン切り替え(2D)", "別シーンに切り替えます", 5592405, 4473992)]
  public class Event2dAction_Scene : EventAction_SceneBase
  {
    [Token(Token = "0x400452D")]
    [FieldOffset(Offset = "0x18")]
    [StringIsSceneID]
    public string SceneID;
    [Token(Token = "0x400452E")]
    [FieldOffset(Offset = "0x1C")]
    private SceneRequest mAsyncOp;
    [Token(Token = "0x400452F")]
    [FieldOffset(Offset = "0x20")]
    private GameObject mSceneRoot;
    [Token(Token = "0x4004530")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public bool FadeIn;
    [Token(Token = "0x4004531")]
    [FieldOffset(Offset = "0x25")]
    [HideInInspector]
    public bool WaitFadeIn;
    [Token(Token = "0x4004532")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public float FadeInTime;

    [Token(Token = "0x6004EE3")]
    [Address(RVA = "0x1243140", Offset = "0x1241F40", VA = "0x11243140", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EE4")]
    [Address(RVA = "0x1243300", Offset = "0x1242100", VA = "0x11243300")]
    private void OnSceneLoad(GameObject sceneRoot)
    {
    }

    [Token(Token = "0x6004EE5")]
    [Address(RVA = "0x1243430", Offset = "0x1242230", VA = "0x11243430", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004EE6")]
    [Address(RVA = "0x1243110", Offset = "0x1241F10", VA = "0x11243110")]
    public Event2dAction_Scene()
    {
    }
  }
}
