// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_SpawnObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012A9")]
  [EventActionInfo("オブジェクト/配置(2D)", "シーンにオブジェクトを配置します。", 5592405, 4473992)]
  public class Event2dAction_SpawnObject : EventAction
  {
    [Token(Token = "0x400455D")]
    public const string ResourceDir = "Event2dAssets/";
    [Token(Token = "0x400455E")]
    [FieldOffset(Offset = "0x18")]
    [StringIsResourcePath(typeof (GameObject), "Event2dAssets/")]
    public string ResourceID;
    [Token(Token = "0x400455F")]
    [FieldOffset(Offset = "0x1C")]
    public string ObjectID;
    [Token(Token = "0x4004560")]
    [FieldOffset(Offset = "0x20")]
    private LoadRequest mResourceLoadRequest;
    [Token(Token = "0x4004561")]
    [FieldOffset(Offset = "0x24")]
    public bool Persistent;
    [Token(Token = "0x4004562")]
    [FieldOffset(Offset = "0x28")]
    public Vector3 Position;
    [Token(Token = "0x4004563")]
    [FieldOffset(Offset = "0x34")]
    private GameObject mGO;

    [Token(Token = "0x6004F17")]
    [Address(RVA = "0x1245120", Offset = "0x1243F20", VA = "0x11245120", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F18")]
    [Address(RVA = "0x1245440", Offset = "0x1244240", VA = "0x11245440", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x170008DB")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004F19"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004F1A")]
    [Address(RVA = "0x1245520", Offset = "0x1244320", VA = "0x11245520", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004F1B")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_SpawnObject()
    {
    }
  }
}
