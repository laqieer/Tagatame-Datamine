// Decompiled with JetBrains decompiler
// Type: SRPG.AppealItemEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FB8")]
  [AddComponentMenu("UI/AppealItemEvent")]
  public class AppealItemEvent : AppealItemBase
  {
    [Token(Token = "0x4008665")]
    [FieldOffset(Offset = "0x14")]
    private readonly string SPRITES_PATH;
    [Token(Token = "0x4008666")]
    [FieldOffset(Offset = "0x18")]
    private readonly string MASTER_PATH;
    [Token(Token = "0x4008667")]
    [FieldOffset(Offset = "0x1C")]
    private string[] mAppealIds;
    [Token(Token = "0x4008668")]
    [FieldOffset(Offset = "0x20")]
    private string mAppealId;
    [Token(Token = "0x4008669")]
    [FieldOffset(Offset = "0x24")]
    private bool IsLoaded;
    [Token(Token = "0x400866A")]
    [FieldOffset(Offset = "0x28")]
    protected Dictionary<string, Sprite> mCacheAppealSprites;
    [Token(Token = "0x400866B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject Ballon;
    [Token(Token = "0x400866C")]
    [FieldOffset(Offset = "0x30")]
    private bool IsNew;

    [Token(Token = "0x60082B4")]
    [Address(RVA = "0x435A80", Offset = "0x434880", VA = "0x10435A80", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x60082B5")]
    [Address(RVA = "0x436040", Offset = "0x434E40", VA = "0x10436040", Slot = "5")]
    protected override void Start()
    {
    }

    [Token(Token = "0x60082B6")]
    [Address(RVA = "0x4360C0", Offset = "0x434EC0", VA = "0x104360C0", Slot = "6")]
    protected override void Update()
    {
    }

    [Token(Token = "0x60082B7")]
    [Address(RVA = "0x435B00", Offset = "0x434900", VA = "0x10435B00", Slot = "7")]
    protected override void Destroy()
    {
    }

    [Token(Token = "0x60082B8")]
    [Address(RVA = "0x435C90", Offset = "0x434A90", VA = "0x10435C90")]
    private bool LoadAppealMaster(string path) => new bool();

    [Token(Token = "0x60082B9")]
    [Address(RVA = "0x435FD0", Offset = "0x434DD0", VA = "0x10435FD0")]
    private IEnumerator LoadAppealResources() => (IEnumerator) null;

    [Token(Token = "0x60082BA")]
    [Address(RVA = "0x436210", Offset = "0x435010", VA = "0x10436210")]
    public AppealItemEvent()
    {
    }
  }
}
