// Decompiled with JetBrains decompiler
// Type: SRPG.WeatherTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C6C")]
  [AddComponentMenu("Battle/BattleUI/WeatherTooltip")]
  public class WeatherTooltip : MonoBehaviour
  {
    [Token(Token = "0x4002184")]
    [FieldOffset(Offset = "0xC")]
    public WeatherTooltip.eDispType DispType;
    [Token(Token = "0x4002185")]
    [FieldOffset(Offset = "0x10")]
    public Tooltip PrefabTooltip;
    [Token(Token = "0x4002186")]
    [FieldOffset(Offset = "0x14")]
    public float PosLeftOffset;
    [Token(Token = "0x4002187")]
    [FieldOffset(Offset = "0x18")]
    public float PosRightOffset;
    [Token(Token = "0x4002188")]
    [FieldOffset(Offset = "0x1C")]
    public float PosUpOffset;
    [Token(Token = "0x4002189")]
    [FieldOffset(Offset = "0x0")]
    private static Tooltip mTooltip;
    [Token(Token = "0x400218A")]
    [FieldOffset(Offset = "0x20")]
    private CanvasGroup[] mParentCgs;

    [Token(Token = "0x60030FA")]
    [Address(RVA = "0x102F530", Offset = "0x102E330", VA = "0x1102F530")]
    private void Start()
    {
    }

    [Token(Token = "0x170002EE")]
    private CanvasGroup[] ParentCgs
    {
      [Token(Token = "0x60030FB"), Address(RVA = "0x102F6B0", Offset = "0x102E4B0", VA = "0x1102F6B0")] get
      {
        return (CanvasGroup[]) null;
      }
    }

    [Token(Token = "0x60030FC")]
    [Address(RVA = "0x102F1C0", Offset = "0x102DFC0", VA = "0x1102F1C0")]
    private void ShowTooltip(PointerEventData event_data)
    {
    }

    [Token(Token = "0x60030FD")]
    [Address(RVA = "0x102F150", Offset = "0x102DF50", VA = "0x1102F150")]
    private IEnumerator ResetPosiotion() => (IEnumerator) null;

    [Token(Token = "0x60030FE")]
    [Address(RVA = "0x102F680", Offset = "0x102E480", VA = "0x1102F680")]
    public WeatherTooltip()
    {
    }

    [Token(Token = "0x2000C6D")]
    public enum eDispType
    {
      [Token(Token = "0x400218C")] LEFT,
      [Token(Token = "0x400218D")] RIGHT,
      [Token(Token = "0x400218E")] UP,
    }
  }
}
