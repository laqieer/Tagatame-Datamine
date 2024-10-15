// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchResult
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
  [Token(Token = "0x2002927")]
  [FlowNode.Pin(10, "演出開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "演出スキップ", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(31, "終了", FlowNode.PinTypes.Output, 31)]
  [FlowNode.Pin(30, "終了チェック", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(32, "昇格演出", FlowNode.PinTypes.Output, 32)]
  [FlowNode.Pin(33, "降格演出", FlowNode.PinTypes.Output, 33)]
  [AddComponentMenu("UI/RankMatchResult")]
  [FlowNode.Pin(20, "演出終了", FlowNode.PinTypes.Output, 20)]
  public class RankMatchResult : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C617")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ResultWin;
    [Token(Token = "0x400C618")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ResultLose;
    [Token(Token = "0x400C619")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ResultDraw;
    [Token(Token = "0x400C61A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text RankLabel;
    [Token(Token = "0x400C61B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text UpRankLabel;
    [Token(Token = "0x400C61C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text ScoreLabel;
    [Token(Token = "0x400C61D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text UpScoreLabel;
    [Token(Token = "0x400C61E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text NextLabel;
    [Token(Token = "0x400C61F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Slider NextSlider;
    [Token(Token = "0x400C620")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ImageArray RankUpDownImg;
    [Token(Token = "0x400C621")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject Result;
    [Token(Token = "0x400C622")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject UpEffect;
    [Token(Token = "0x400C623")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject DownEffect;
    [Token(Token = "0x400C624")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject UpImage;
    [Token(Token = "0x400C625")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject DownImage;
    [Token(Token = "0x400C626")]
    private const int MAX_FRAME = 60;
    [Token(Token = "0x400C627")]
    [FieldOffset(Offset = "0x48")]
    private int mCounter;

    [Token(Token = "0x600BA29")]
    [Address(RVA = "0x818180", Offset = "0x816F80", VA = "0x10818180")]
    private void Start()
    {
    }

    [Token(Token = "0x600BA2A")]
    [Address(RVA = "0x817A40", Offset = "0x816840", VA = "0x10817A40", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BA2B")]
    [Address(RVA = "0x817AE0", Offset = "0x8168E0", VA = "0x10817AE0")]
    private void CheckFinish()
    {
    }

    [Token(Token = "0x600BA2C")]
    [Address(RVA = "0x817EC0", Offset = "0x816CC0", VA = "0x10817EC0")]
    private IEnumerator PlayAnimationAsync() => (IEnumerator) null;

    [Token(Token = "0x600BA2D")]
    [Address(RVA = "0x817F30", Offset = "0x816D30", VA = "0x10817F30")]
    private void Refresh(int score, int rank, int up_rank, int up_score, ref int class_num)
    {
    }

    [Token(Token = "0x600BA2E")]
    [Address(RVA = "0x817DC0", Offset = "0x816BC0", VA = "0x10817DC0")]
    private UnitData GetUnitData() => (UnitData) null;

    [Token(Token = "0x600BA2F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RankMatchResult()
    {
    }
  }
}
