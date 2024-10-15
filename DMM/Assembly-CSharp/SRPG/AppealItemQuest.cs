// Decompiled with JetBrains decompiler
// Type: SRPG.AppealItemQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FCE")]
  [AddComponentMenu("UI/AppealItemQuest")]
  public class AppealItemQuest : AppealItemBase
  {
    [Token(Token = "0x40086D9")]
    [FieldOffset(Offset = "0x14")]
    private readonly string SPRITES_PATH;
    [Token(Token = "0x40086DA")]
    [FieldOffset(Offset = "0x18")]
    private readonly string MASTER_PATH;
    [Token(Token = "0x40086DB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Image AppealObject1;
    [Token(Token = "0x40086DC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup AppealGroup0;
    [Token(Token = "0x40086DD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private CanvasGroup AppealGroup1;
    [Token(Token = "0x40086DE")]
    [FieldOffset(Offset = "0x28")]
    private string[] mAppealIds;
    [Token(Token = "0x40086DF")]
    [FieldOffset(Offset = "0x2C")]
    private int mCurrentIndex;
    [Token(Token = "0x40086E0")]
    [FieldOffset(Offset = "0x30")]
    private bool IsLoaded;
    [Token(Token = "0x40086E1")]
    [FieldOffset(Offset = "0x34")]
    protected Dictionary<string, Sprite> mCacheAppealSprites;
    [Token(Token = "0x40086E2")]
    [FieldOffset(Offset = "0x38")]
    private readonly float WAIT_SWAP_APPEAL;
    [Token(Token = "0x40086E3")]
    [FieldOffset(Offset = "0x3C")]
    private float mWaitSwapeAppealTime;
    [Token(Token = "0x40086E4")]
    [FieldOffset(Offset = "0x40")]
    private Sprite mCurrentSprite;
    [Token(Token = "0x40086E5")]
    [FieldOffset(Offset = "0x44")]
    private Sprite mNextSprite;
    [Token(Token = "0x40086E6")]
    [FieldOffset(Offset = "0x48")]
    private bool IsUpdated;

    [Token(Token = "0x60082FD")]
    [Address(RVA = "0x437630", Offset = "0x436430", VA = "0x10437630", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x60082FE")]
    [Address(RVA = "0x438040", Offset = "0x436E40", VA = "0x10438040", Slot = "5")]
    protected override void Start()
    {
    }

    [Token(Token = "0x60082FF")]
    [Address(RVA = "0x438340", Offset = "0x437140", VA = "0x10438340", Slot = "6")]
    protected override void Update()
    {
    }

    [Token(Token = "0x6008300")]
    [Address(RVA = "0x4380C0", Offset = "0x436EC0", VA = "0x104380C0")]
    private void UpdateAppeal()
    {
    }

    [Token(Token = "0x6008301")]
    [Address(RVA = "0x437C90", Offset = "0x436A90", VA = "0x10437C90", Slot = "9")]
    protected override void Refresh()
    {
    }

    [Token(Token = "0x6008302")]
    [Address(RVA = "0x4376C0", Offset = "0x4364C0", VA = "0x104376C0", Slot = "7")]
    protected override void Destroy()
    {
    }

    [Token(Token = "0x6008303")]
    [Address(RVA = "0x437850", Offset = "0x436650", VA = "0x10437850")]
    private bool LoadAppealMaster(string path) => new bool();

    [Token(Token = "0x6008304")]
    [Address(RVA = "0x437C20", Offset = "0x436A20", VA = "0x10437C20")]
    private IEnumerator LoadAppealResources() => (IEnumerator) null;

    [Token(Token = "0x6008305")]
    [Address(RVA = "0x438380", Offset = "0x437180", VA = "0x10438380")]
    public AppealItemQuest()
    {
    }
  }
}
