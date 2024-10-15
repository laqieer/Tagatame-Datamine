// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDisassemblyEffectWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002979")]
  [AddComponentMenu("UI/Rune/RuneDisassemblyEffectWindow")]
  [FlowNode.Pin(10, "自身を閉じてルーン一覧へ", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "分解ウィンドウを開く", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(202, "超成功時", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(201, "大成功時", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(200, "成功時", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(1000, "自身を閉じる処理を呼出後", FlowNode.PinTypes.Output, 1000)]
  public class RuneDisassemblyEffectWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C81E")]
    private const int INPUT_CLOSE = 10;
    [Token(Token = "0x400C81F")]
    private const int OUTPUT_OPEN_RUNE_DISASSEMBLY = 100;
    [Token(Token = "0x400C820")]
    private const int OUTPUT_RESULT_SUCCESS = 200;
    [Token(Token = "0x400C821")]
    private const int OUTPUT_RESULT_GREAT = 201;
    [Token(Token = "0x400C822")]
    private const int OUTPUT_RESULT_SUPER = 202;
    [Token(Token = "0x400C823")]
    private const int OUTPUT_CLOSE_WINDOW = 1000;
    [Token(Token = "0x400C824")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ItemIcon mItemIcon;
    [Token(Token = "0x400C825")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneDrawDisassemblyEffect mRuneDrawDisassemblyEffect;
    [Token(Token = "0x400C826")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Image[] mImageReplaceFrom;
    [Token(Token = "0x400C827")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image[] mImageReplace;
    [Token(Token = "0x400C828")]
    [FieldOffset(Offset = "0x1C")]
    private RuneManager mRuneManager;
    [Token(Token = "0x400C829")]
    [FieldOffset(Offset = "0x20")]
    private ReqRuneDisassembly.Response.Result mResult;

    [Token(Token = "0x600BBD0")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BBD1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BBD2")]
    [Address(RVA = "0x834840", Offset = "0x833640", VA = "0x10834840", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BBD3")]
    [Address(RVA = "0x834AE0", Offset = "0x8338E0", VA = "0x10834AE0")]
    public void Setup(RuneManager manager, ReqRuneDisassembly.Response res)
    {
    }

    [Token(Token = "0x600BBD4")]
    [Address(RVA = "0x8349B0", Offset = "0x8337B0", VA = "0x108349B0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BBD5")]
    [Address(RVA = "0x8348E0", Offset = "0x8336E0", VA = "0x108348E0")]
    public void ImageReplace()
    {
    }

    [Token(Token = "0x600BBD6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneDisassemblyEffectWindow()
    {
    }
  }
}
