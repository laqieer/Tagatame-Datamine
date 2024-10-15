// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidBossIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002573")]
  [FlowNode.Pin(1, "Next Effect", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Next Effect Start", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(2, "Beat Effect Prepare", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "Beat Effect Execute", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "Challenge Effect Start", FlowNode.PinTypes.Input, 4)]
  [AddComponentMenu("UI/GuildRaid/GuildRaidBossIcon")]
  public class GuildRaidBossIcon : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AD01")]
    public const int PIN_INPUT_NEXT_EFFECT = 1;
    [Token(Token = "0x400AD02")]
    public const int PIN_INPUT_BEAT_PREPARE = 2;
    [Token(Token = "0x400AD03")]
    public const int PIN_INPUT_BEAT_EXECUTE = 3;
    [Token(Token = "0x400AD04")]
    public const int PIN_INPUT_START_CHELLENGE_EFFECT = 4;
    [Token(Token = "0x400AD05")]
    public const int PIN_OUTPUT_NEXT_EFFECT_START = 101;
    [Token(Token = "0x400AD06")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Button mButton;
    [Token(Token = "0x400AD07")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mClosed;
    [Token(Token = "0x400AD08")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mChallenge;
    [Token(Token = "0x400AD09")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mCleared;
    [Token(Token = "0x400AD0A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mWait;
    [Token(Token = "0x400AD0B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mNoCleared;
    [Token(Token = "0x400AD0C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mCursor;
    [Token(Token = "0x400AD0D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CustomSound mCursorSound;
    [Token(Token = "0x400AD0E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mDetail;
    [Token(Token = "0x400AD0F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mBattle;
    [Token(Token = "0x400AD10")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mNumberText;
    [Token(Token = "0x400AD11")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mBeatEffect;
    [Token(Token = "0x400AD12")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mChallengeObject;
    [Token(Token = "0x400AD13")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mLastBossObject;
    [Token(Token = "0x400AD14")]
    [FieldOffset(Offset = "0x44")]
    private GameObject mLastBeatIcon;
    [Token(Token = "0x400AD15")]
    [FieldOffset(Offset = "0x48")]
    private GuildRaidBossParam mGuildRaidBoss;
    [Token(Token = "0x400AD16")]
    [FieldOffset(Offset = "0x4C")]
    private int mRound;
    [Token(Token = "0x400AD17")]
    [FieldOffset(Offset = "0x50")]
    private int mNo;
    [Token(Token = "0x400AD18")]
    [FieldOffset(Offset = "0x54")]
    private float animatorSpeed;
    [Token(Token = "0x400AD19")]
    [FieldOffset(Offset = "0x58")]
    private bool IsCurrentBoss;

    [Token(Token = "0x17001721")]
    public bool IsClosed
    {
      [Token(Token = "0x600A5CE"), Address(RVA = "0x67D3E0", Offset = "0x67C1E0", VA = "0x1067D3E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A5CF")]
    [Address(RVA = "0x67CB50", Offset = "0x67B950", VA = "0x1067CB50")]
    public void Awake()
    {
    }

    [Token(Token = "0x600A5D0")]
    [Address(RVA = "0x67CF20", Offset = "0x67BD20", VA = "0x1067CF20")]
    public void Setup(GuildRaidBossParam param, int round, int no)
    {
    }

    [Token(Token = "0x600A5D1")]
    [Address(RVA = "0x67CBE0", Offset = "0x67B9E0", VA = "0x1067CBE0")]
    private bool IsChallengeBoss(GuildRaidBossParam _param) => new bool();

    [Token(Token = "0x600A5D2")]
    [Address(RVA = "0x67C520", Offset = "0x67B320", VA = "0x1067C520", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A5D3")]
    [Address(RVA = "0x67C810", Offset = "0x67B610", VA = "0x1067C810")]
    public void Active()
    {
    }

    [Token(Token = "0x600A5D4")]
    [Address(RVA = "0x67CD30", Offset = "0x67BB30", VA = "0x1067CD30")]
    public void SetCursor(bool active, bool sound = true)
    {
    }

    [Token(Token = "0x600A5D5")]
    [Address(RVA = "0x67CCE0", Offset = "0x67BAE0", VA = "0x1067CCE0")]
    public void OnClearedDetail()
    {
    }

    [Token(Token = "0x600A5D6")]
    [Address(RVA = "0x67CDE0", Offset = "0x67BBE0", VA = "0x1067CDE0")]
    public void SetLastBossIcon(bool _active)
    {
    }

    [Token(Token = "0x600A5D7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildRaidBossIcon()
    {
    }
  }
}
