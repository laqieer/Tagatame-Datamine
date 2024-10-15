// Decompiled with JetBrains decompiler
// Type: SRPG.AwardItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002074")]
  [AddComponentMenu("UI/AwardItem")]
  [FlowNode.Pin(0, "UpdateConfigPlayerInfo", FlowNode.PinTypes.Input, 0)]
  public class AwardItem : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008BC5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject AwardBG;
    [Token(Token = "0x4008BC6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text AwardTxt;
    [Token(Token = "0x4008BC7")]
    [FieldOffset(Offset = "0x14")]
    public AwardItem.PlayerType Type;
    [Token(Token = "0x4008BC8")]
    [FieldOffset(Offset = "0x18")]
    private ImageArray mImageArray;
    [Token(Token = "0x4008BC9")]
    [FieldOffset(Offset = "0x1C")]
    private bool IsDone;
    [Token(Token = "0x4008BCA")]
    [FieldOffset(Offset = "0x20")]
    private string mSelectedAward;
    [Token(Token = "0x4008BCB")]
    [FieldOffset(Offset = "0x24")]
    private bool IsRefresh;
    [Token(Token = "0x4008BCC")]
    [FieldOffset(Offset = "0x28")]
    private AwardParam mAwardParam;
    [Token(Token = "0x4008BCD")]
    [FieldOffset(Offset = "0x2C")]
    private bool IsNotUseDataSourse;

    [Token(Token = "0x6008703")]
    [Address(RVA = "0x484550", Offset = "0x483350", VA = "0x10484550", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008704")]
    [Address(RVA = "0x484570", Offset = "0x483370", VA = "0x10484570")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008705")]
    [Address(RVA = "0x4846E0", Offset = "0x4834E0", VA = "0x104846E0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008706")]
    [Address(RVA = "0x4846E0", Offset = "0x4834E0", VA = "0x104846E0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6008707")]
    [Address(RVA = "0x4846E0", Offset = "0x4834E0", VA = "0x104846E0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6008708")]
    [Address(RVA = "0x484DF0", Offset = "0x483BF0", VA = "0x10484DF0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008709")]
    [Address(RVA = "0x484B90", Offset = "0x483990", VA = "0x10484B90")]
    private void SetUp()
    {
    }

    [Token(Token = "0x600870A")]
    [Address(RVA = "0x484700", Offset = "0x483500", VA = "0x10484700")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600870B")]
    [Address(RVA = "0x484A50", Offset = "0x483850", VA = "0x10484A50")]
    public void SetAwardParam(AwardParam award_param)
    {
    }

    [Token(Token = "0x600870C")]
    [Address(RVA = "0x484A80", Offset = "0x483880", VA = "0x10484A80")]
    private bool SetExtraAwardImage() => new bool();

    [Token(Token = "0x600870D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AwardItem()
    {
    }

    [Token(Token = "0x2002075")]
    public enum PlayerType : byte
    {
      [Token(Token = "0x4008BCF")] Player = 0,
      [Token(Token = "0x4008BD0")] Friend = 1,
      [Token(Token = "0x4008BD1")] ArenaPlayer = 2,
      [Token(Token = "0x4008BD2")] MultiPlayer = 3,
      [Token(Token = "0x4008BD3")] ChatPlayer = 4,
      [Token(Token = "0x4008BD4")] TowerPlayer = 5,
      [Token(Token = "0x4008BD5")] GuildMember = 6,
      [Token(Token = "0x4008BD6")] AwardParam = 100, // 0x64
    }
  }
}
