// Decompiled with JetBrains decompiler
// Type: SRPG.ChatStamp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002164")]
  [AddComponentMenu("UI/ChatStamp")]
  [FlowNode.Pin(0, "SetStampId", FlowNode.PinTypes.Output, 0)]
  public class ChatStamp : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40091AF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform StampListRoot;
    [Token(Token = "0x40091B0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button NextPage;
    [Token(Token = "0x40091B1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button PrevPage;
    [Token(Token = "0x40091B2")]
    [FieldOffset(Offset = "0x18")]
    private GameObject[] mStampObjects;
    [Token(Token = "0x40091B3")]
    [FieldOffset(Offset = "0x1C")]
    private ChatStampParam[] mStampParams;
    [Token(Token = "0x40091B4")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string CHAT_STAMP_MASTER_PATH;
    [Token(Token = "0x40091B5")]
    [FieldOffset(Offset = "0x4")]
    public static readonly string CHAT_STAMP_IMAGE_PATH;
    [Token(Token = "0x40091B6")]
    [FieldOffset(Offset = "0x8")]
    public static readonly int STAMP_VIEW_MAX;
    [Token(Token = "0x40091B7")]
    [FieldOffset(Offset = "0x20")]
    private int MaxPage;
    [Token(Token = "0x40091B8")]
    [FieldOffset(Offset = "0x24")]
    private int mCurrentPageIndex;
    [Token(Token = "0x40091B9")]
    [FieldOffset(Offset = "0x28")]
    private bool IsRefresh;
    [Token(Token = "0x40091BA")]
    [FieldOffset(Offset = "0x29")]
    private bool IsSending;
    [Token(Token = "0x40091BB")]
    [FieldOffset(Offset = "0x2C")]
    private int mPrevSelectId;
    [Token(Token = "0x40091BC")]
    [FieldOffset(Offset = "0x30")]
    private int mPrevSelectIndex;
    [Token(Token = "0x40091BD")]
    [FieldOffset(Offset = "0x34")]
    private SpriteSheet mStampImages;
    [Token(Token = "0x40091BE")]
    [FieldOffset(Offset = "0x38")]
    private bool IsImageLoaded;
    [Token(Token = "0x40091BF")]
    [FieldOffset(Offset = "0x39")]
    private bool mImageLoaded;

    [Token(Token = "0x6008C59")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008C5A")]
    [Address(RVA = "0x500270", Offset = "0x4FF070", VA = "0x10500270")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008C5B")]
    [Address(RVA = "0x500540", Offset = "0x4FF340", VA = "0x10500540")]
    private void OnNext()
    {
    }

    [Token(Token = "0x6008C5C")]
    [Address(RVA = "0x500580", Offset = "0x4FF380", VA = "0x10500580")]
    private void OnPrev()
    {
    }

    [Token(Token = "0x6008C5D")]
    [Address(RVA = "0x500DD0", Offset = "0x4FFBD0", VA = "0x10500DD0")]
    private bool SetupChatStampMaster() => new bool();

    [Token(Token = "0x6008C5E")]
    [Address(RVA = "0x5010E0", Offset = "0x4FFEE0", VA = "0x105010E0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008C5F")]
    [Address(RVA = "0x500530", Offset = "0x4FF330", VA = "0x10500530")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6008C60")]
    [Address(RVA = "0x500440", Offset = "0x4FF240", VA = "0x10500440")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6008C61")]
    [Address(RVA = "0x5007B0", Offset = "0x4FF5B0", VA = "0x105007B0")]
    private void RefreshPager()
    {
    }

    [Token(Token = "0x6008C62")]
    [Address(RVA = "0x501220", Offset = "0x500020", VA = "0x10501220")]
    private void Update()
    {
    }

    [Token(Token = "0x6008C63")]
    [Address(RVA = "0x500880", Offset = "0x4FF680", VA = "0x10500880")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008C64")]
    [Address(RVA = "0x5005C0", Offset = "0x4FF3C0", VA = "0x105005C0")]
    private void OnTapStamp(int id, int index)
    {
    }

    [Token(Token = "0x6008C65")]
    [Address(RVA = "0x5003D0", Offset = "0x4FF1D0", VA = "0x105003D0")]
    private IEnumerator LoadStampImages() => (IEnumerator) null;

    [Token(Token = "0x6008C66")]
    [Address(RVA = "0x5012E0", Offset = "0x5000E0", VA = "0x105012E0")]
    public ChatStamp()
    {
    }

    [Token(Token = "0x6008C67")]
    [Address(RVA = "0x501250", Offset = "0x500050", VA = "0x10501250")]
    static ChatStamp()
    {
    }
  }
}
