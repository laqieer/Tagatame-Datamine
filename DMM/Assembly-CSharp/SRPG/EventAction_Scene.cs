// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_Scene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001231")]
  [EventActionInfo("シーン切り替え", "別シーンに切り替えます", 5592405, 4473992)]
  public class EventAction_Scene : EventAction_SceneBase
  {
    [Token(Token = "0x40042E5")]
    [FieldOffset(Offset = "0x18")]
    [StringIsSceneID]
    public string SceneID;
    [Token(Token = "0x40042E6")]
    [FieldOffset(Offset = "0x1C")]
    private SceneRequest mAsyncOp;
    [Token(Token = "0x40042E7")]
    [FieldOffset(Offset = "0x20")]
    private GameObject mSceneRoot;
    [Token(Token = "0x40042E8")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public bool FadeIn;
    [Token(Token = "0x40042E9")]
    [FieldOffset(Offset = "0x25")]
    [HideInInspector]
    public bool WaitFadeIn;
    [Token(Token = "0x40042EA")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public float FadeInTime;

    [Token(Token = "0x6004D1B")]
    [Address(RVA = "0x122F050", Offset = "0x122DE50", VA = "0x1122F050", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D1C")]
    [Address(RVA = "0x122F210", Offset = "0x122E010", VA = "0x1122F210")]
    private void OnSceneLoad(GameObject sceneRoot)
    {
    }

    [Token(Token = "0x6004D1D")]
    [Address(RVA = "0x122F340", Offset = "0x122E140", VA = "0x1122F340", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004D1E")]
    [Address(RVA = "0x122F480", Offset = "0x122E280", VA = "0x1122F480")]
    public EventAction_Scene()
    {
    }
  }
}
