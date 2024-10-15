// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawBaseState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200297C")]
  [AddComponentMenu("UI/Rune/RuneDrawBaseState")]
  public class RuneDrawBaseState : MonoBehaviour
  {
    [Token(Token = "0x400C84E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private StatusList mBaseStatusList;
    [Token(Token = "0x400C84F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mBaseStatusRange;
    [Token(Token = "0x400C850")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneDrawEvoStateOneSetting mOneSetting;
    [Token(Token = "0x400C851")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RuneDrawBaseState.eDrawMode mDrawMode;
    [Token(Token = "0x400C852")]
    [FieldOffset(Offset = "0x1C")]
    private BindRuneData mRuneData;
    [Token(Token = "0x400C853")]
    [FieldOffset(Offset = "0x20")]
    private ColorBlock mKeepButtonColor;
    [Token(Token = "0x400C854")]
    [FieldOffset(Offset = "0x78")]
    private bool mIsUseKeepButtonColor;

    [Token(Token = "0x1400000F")]
    private event RuneDrawBaseState.OnSelectedEvent mOnSelectedEvent
    {
      [Token(Token = "0x600BBF4"), Address(RVA = "0x83B360", Offset = "0x83A160", VA = "0x1083B360")] add
      {
      }
      [Token(Token = "0x600BBF5"), Address(RVA = "0x83B3E0", Offset = "0x83A1E0", VA = "0x1083B3E0")] remove
      {
      }
    }

    [Token(Token = "0x600BBF6")]
    [Address(RVA = "0x5A4130", Offset = "0x5A2F30", VA = "0x105A4130")]
    public void SetSelectedCallBack(RuneDrawBaseState.OnSelectedEvent selected)
    {
    }

    [Token(Token = "0x600BBF7")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BBF8")]
    [Address(RVA = "0x83AFD0", Offset = "0x839DD0", VA = "0x1083AFD0")]
    public void SetDrawParam(BindRuneData rune_data)
    {
    }

    [Token(Token = "0x600BBF9")]
    [Address(RVA = "0x83AC40", Offset = "0x839A40", VA = "0x1083AC40")]
    public void SetButtonInteractable(bool enable)
    {
    }

    [Token(Token = "0x600BBFA")]
    [Address(RVA = "0x83AD00", Offset = "0x839B00", VA = "0x1083AD00")]
    public void SetDisableColor(bool is_hilight)
    {
    }

    [Token(Token = "0x600BBFB")]
    [Address(RVA = "0x83A790", Offset = "0x839590", VA = "0x1083A790")]
    public void OnClickBaseItem()
    {
    }

    [Token(Token = "0x600BBFC")]
    [Address(RVA = "0x83B100", Offset = "0x839F00", VA = "0x1083B100")]
    public void ShowFrame(bool is_show)
    {
    }

    [Token(Token = "0x600BBFD")]
    [Address(RVA = "0x83B170", Offset = "0x839F70", VA = "0x1083B170")]
    public void StartGaugeAnim()
    {
    }

    [Token(Token = "0x600BBFE")]
    [Address(RVA = "0x83AC30", Offset = "0x839A30", VA = "0x1083AC30")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BBFF")]
    [Address(RVA = "0x83A740", Offset = "0x839540", VA = "0x1083A740")]
    private void GetBaseStatusLotteryWidth(RuneData rune, out int lot_min, out int lot_max)
    {
    }

    [Token(Token = "0x600BC00")]
    [Address(RVA = "0x83A7C0", Offset = "0x8395C0", VA = "0x1083A7C0")]
    private void RefreshBaseStatus()
    {
    }

    [Token(Token = "0x600BC01")]
    [Address(RVA = "0x83B1E0", Offset = "0x839FE0", VA = "0x1083B1E0")]
    public RuneDrawBaseState()
    {
    }

    [Token(Token = "0x200297D")]
    public enum eDrawMode
    {
      [Token(Token = "0x400C857")] TotalStatus,
      [Token(Token = "0x400C858")] TotalStatusAndBonus,
      [Token(Token = "0x400C859")] OnlyBaseStatus,
    }

    [Token(Token = "0x200297E")]
    public delegate void OnSelectedEvent();
  }
}
