// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SpawnObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200124A")]
  [EventActionInfo("オブジェクト/配置", "シーンにオブジェクトを配置します。", 4478293, 4491400)]
  public class EventAction_SpawnObject : EventAction
  {
    [Token(Token = "0x4004357")]
    public const string ResourceDir = "EventAssets/";
    [Token(Token = "0x4004358")]
    [FieldOffset(Offset = "0x18")]
    [StringIsResourcePath(typeof (GameObject), "EventAssets/")]
    public string ResourceID;
    [Token(Token = "0x4004359")]
    [FieldOffset(Offset = "0x1C")]
    public string ObjectID;
    [Token(Token = "0x400435A")]
    [FieldOffset(Offset = "0x20")]
    private LoadRequest mResourceLoadRequest;
    [Token(Token = "0x400435B")]
    [FieldOffset(Offset = "0x24")]
    public bool Persistent;
    [Token(Token = "0x400435C")]
    [FieldOffset(Offset = "0x28")]
    public Vector3 Position;
    [Token(Token = "0x400435D")]
    [FieldOffset(Offset = "0x34")]
    private GameObject mGO;

    [Token(Token = "0x6004D77")]
    [Address(RVA = "0x1231830", Offset = "0x1230630", VA = "0x11231830", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D78")]
    [Address(RVA = "0x1231B50", Offset = "0x1230950", VA = "0x11231B50", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x170008A9")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004D79"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004D7A")]
    [Address(RVA = "0x1231C30", Offset = "0x1230A30", VA = "0x11231C30", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D7B")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public EventAction_SpawnObject()
    {
    }
  }
}
