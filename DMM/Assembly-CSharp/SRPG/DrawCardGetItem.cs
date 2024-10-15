// Decompiled with JetBrains decompiler
// Type: SRPG.DrawCardGetItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022FB")]
  [AddComponentMenu("UI/DrawCard/DrawCardGetItem")]
  public class DrawCardGetItem : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x4009C18")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mUnitObject;
    [Token(Token = "0x4009C19")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mItemObject;
    [Token(Token = "0x4009C1A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mArtifactObject;
    [Token(Token = "0x4009C1B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mGoldObject;
    [Token(Token = "0x4009C1C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mGoldAmount;
    [Token(Token = "0x4009C1D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mCoinObject;
    [Token(Token = "0x4009C1E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mCoinAmount;
    [Token(Token = "0x4009C1F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mConceptCardObject;
    [Token(Token = "0x4009C20")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mJokerObject;

    [Token(Token = "0x6009670")]
    [Address(RVA = "0x593540", Offset = "0x592340", VA = "0x10593540", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x6009671")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DrawCardGetItem()
    {
    }
  }
}
