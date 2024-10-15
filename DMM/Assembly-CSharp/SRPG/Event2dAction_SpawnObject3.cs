// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_SpawnObject3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012AD")]
  [EventActionInfo("New/オブジェクト/配置2(2D)", "シーンにオブジェクトを配置します。", 5592405, 4473992)]
  public class Event2dAction_SpawnObject3 : EventAction
  {
    [Token(Token = "0x4004571")]
    public const string ResourceDir = "Event2dAssets/";
    [Token(Token = "0x4004572")]
    [FieldOffset(Offset = "0x18")]
    [StringIsResourcePathPopup(typeof (GameObject), "Event2dAssets/")]
    public string ResourceID;
    [Token(Token = "0x4004573")]
    [FieldOffset(Offset = "0x1C")]
    public string ObjectID;
    [Token(Token = "0x4004574")]
    [FieldOffset(Offset = "0x20")]
    private LoadRequest mResourceLoadRequest;
    [Token(Token = "0x4004575")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public bool Persistent;
    [Token(Token = "0x4004576")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public Vector2 Position;
    [Token(Token = "0x4004577")]
    [FieldOffset(Offset = "0x30")]
    private GameObject mGO;
    [Token(Token = "0x4004578")]
    [FieldOffset(Offset = "0x34")]
    public Event2dAction_SpawnObject3.SiblingOrder Order;
    [Token(Token = "0x4004579")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public string CharaID;
    [Token(Token = "0x400457A")]
    [FieldOffset(Offset = "0x3C")]
    [HideInInspector]
    public Event2dAction_SpawnObject3.ActorChildOrder ChildOrder;
    [Token(Token = "0x400457B")]
    [FieldOffset(Offset = "0x40")]
    private RectTransform rectTransform;
    [Token(Token = "0x400457C")]
    [FieldOffset(Offset = "0x44")]
    private Vector2 pvt;

    [Token(Token = "0x170008E1")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004F2D"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004F2E")]
    [Address(RVA = "0x1245020", Offset = "0x1243E20", VA = "0x11245020", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004F2F")]
    [Address(RVA = "0x1244580", Offset = "0x1243380", VA = "0x11244580", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F30")]
    [Address(RVA = "0x1244F40", Offset = "0x1243D40", VA = "0x11244F40", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004F31")]
    [Address(RVA = "0x12450C0", Offset = "0x1243EC0", VA = "0x112450C0")]
    private Vector2 convertPosition(Vector2 pos) => new Vector2();

    [Token(Token = "0x6004F32")]
    [Address(RVA = "0x1245090", Offset = "0x1243E90", VA = "0x11245090")]
    public Event2dAction_SpawnObject3()
    {
    }

    [Token(Token = "0x20012AE")]
    public enum SiblingOrder
    {
      [Token(Token = "0x400457E")] Root,
      [Token(Token = "0x400457F")] OnDialog,
      [Token(Token = "0x4004580")] OnStandChara,
      [Token(Token = "0x4004581")] OnBackGround,
      [Token(Token = "0x4004582")] ChildOfActor,
    }

    [Token(Token = "0x20012AF")]
    public enum ActorChildOrder
    {
      [Token(Token = "0x4004584")] Over,
      [Token(Token = "0x4004585")] Under,
    }
  }
}
