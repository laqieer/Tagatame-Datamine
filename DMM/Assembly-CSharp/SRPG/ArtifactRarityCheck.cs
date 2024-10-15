// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactRarityCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200201F")]
  [FlowNode.Pin(0, "分解を選択", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "売却を選択", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "キャンセルを選択", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(100, "ウィンドウを閉じる", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/ArtifactRarityCheck")]
  public class ArtifactRarityCheck : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008941")]
    private const int INPUT_DECOMPOSE = 0;
    [Token(Token = "0x4008942")]
    private const int INPUT_SELL = 1;
    [Token(Token = "0x4008943")]
    private const int INPUT_CANCEL = 2;
    [Token(Token = "0x4008944")]
    private const int OUTPUT_CLOSE_ACTION = 100;
    [Token(Token = "0x4008945")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mArtifactTemplate;
    [Token(Token = "0x4008946")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RectTransform mArtifactObjectParent;
    [Token(Token = "0x4008947")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private LText mLText;
    [Token(Token = "0x4008948")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mButtonDecompose;
    [Token(Token = "0x4008949")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mButtonSell;
    [Token(Token = "0x400894A")]
    [FieldOffset(Offset = "0x20")]
    private ArtifactRarityCheck.Type mType;
    [Token(Token = "0x400894B")]
    [FieldOffset(Offset = "0x24")]
    public ArtifactRarityCheck.OnArtifactRarityCheckDecideEvent OnDecideEvent;
    [Token(Token = "0x400894C")]
    [FieldOffset(Offset = "0x28")]
    public ArtifactRarityCheck.OnArtifactRarityCheckCancelEvent OnCancelEvent;
    [Token(Token = "0x400894D")]
    [FieldOffset(Offset = "0x2C")]
    private GameObject mArgGo;
    [Token(Token = "0x400894E")]
    [FieldOffset(Offset = "0x30")]
    private List<ArtifactData> mArtifactDataList;
    [Token(Token = "0x400894F")]
    [FieldOffset(Offset = "0x34")]
    private int mRarity;

    [Token(Token = "0x60084E2")]
    [Address(RVA = "0x45AF50", Offset = "0x459D50", VA = "0x1045AF50")]
    private void Start()
    {
    }

    [Token(Token = "0x60084E3")]
    [Address(RVA = "0x45AEC0", Offset = "0x459CC0", VA = "0x1045AEC0")]
    public void Setup(
      ArtifactRarityCheck.Type type,
      GameObject arg_go,
      ArtifactData[] artifact_data,
      int rarity)
    {
    }

    [Token(Token = "0x60084E4")]
    [Address(RVA = "0x45AEA0", Offset = "0x459CA0", VA = "0x1045AEA0")]
    private void OnDecide()
    {
    }

    [Token(Token = "0x60084E5")]
    [Address(RVA = "0x45AE80", Offset = "0x459C80", VA = "0x1045AE80")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x60084E6")]
    [Address(RVA = "0x45AE30", Offset = "0x459C30", VA = "0x1045AE30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60084E7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactRarityCheck()
    {
    }

    [Token(Token = "0x2002020")]
    public enum Type
    {
      [Token(Token = "0x4008951")] NONE,
      [Token(Token = "0x4008952")] SELL,
      [Token(Token = "0x4008953")] DECOMPOSE,
    }

    [Token(Token = "0x2002021")]
    public delegate void OnArtifactRarityCheckDecideEvent(GameObject go);

    [Token(Token = "0x2002022")]
    public delegate void OnArtifactRarityCheckCancelEvent(GameObject go);
  }
}
