// Decompiled with JetBrains decompiler
// Type: SRPG.GenericSlotEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024D7")]
  public class GenericSlotEx : MonoBehaviour
  {
    [Token(Token = "0x400A838")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mBaseExhibitList;
    [Token(Token = "0x400A839")]
    [FieldOffset(Offset = "0x10")]
    public GenericSlotEx.SelectEvent OnSelect;
    [Token(Token = "0x400A83A")]
    [FieldOffset(Offset = "0x14")]
    public Sprite EmptyBG;
    [Token(Token = "0x400A83B")]
    [FieldOffset(Offset = "0x18")]
    public Sprite NonEmptyBG;
    [Token(Token = "0x400A83C")]
    [FieldOffset(Offset = "0x1C")]
    public SRPG_Button SelectButton;
    [Token(Token = "0x400A83D")]
    [FieldOffset(Offset = "0x20")]
    private GenericSlotExModel mGenericSlotExModel;

    [Token(Token = "0x17001697")]
    public int SlotIndex
    {
      [Token(Token = "0x600A1A8"), Address(RVA = "0x638BF0", Offset = "0x6379F0", VA = "0x10638BF0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A1A9")]
    [Address(RVA = "0x638A20", Offset = "0x637820", VA = "0x10638A20")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A1AA")]
    public void Initialize<T>(T data, int slotIndex = -1, bool isHide = false)
    {
    }

    [Token(Token = "0x600A1AB")]
    [Address(RVA = "0x638B30", Offset = "0x637930", VA = "0x10638B30")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600A1AC")]
    [Address(RVA = "0x638AD0", Offset = "0x6378D0", VA = "0x10638AD0")]
    private void OnButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600A1AD")]
    [Address(RVA = "0x638BD0", Offset = "0x6379D0", VA = "0x10638BD0")]
    public void SetMainColor(Color color)
    {
    }

    [Token(Token = "0x600A1AE")]
    [Address(RVA = "0x638BB0", Offset = "0x6379B0", VA = "0x10638BB0")]
    public void SetLocked(bool locked)
    {
    }

    [Token(Token = "0x600A1AF")]
    public void SetSlotData<T>(T data)
    {
    }

    [Token(Token = "0x600A1B0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenericSlotEx()
    {
    }

    [Token(Token = "0x20024D8")]
    public delegate void SelectEvent(GenericSlotEx slot, bool interactable);
  }
}
