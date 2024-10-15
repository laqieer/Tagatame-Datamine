// Decompiled with JetBrains decompiler
// Type: SRPG.MasteryEmblem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002710")]
  [AddComponentMenu("UI/MasteryEmblem")]
  [FlowNode.Pin(0, "UpdateEmblem", FlowNode.PinTypes.Input, 0)]
  public class MasteryEmblem : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B815")]
    private const int PIN_IN_UPDATE = 0;
    [Token(Token = "0x400B816")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SpriteSheet spriteSheet;
    [Token(Token = "0x400B817")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x400B818")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private MasteryEmblem.PlayerType Type;
    [Token(Token = "0x400B819")]
    [FieldOffset(Offset = "0x18")]
    private string emblemPath;

    [Token(Token = "0x600AF1C")]
    [Address(RVA = "0x7357D0", Offset = "0x7345D0", VA = "0x107357D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AF1D")]
    [Address(RVA = "0x7357F0", Offset = "0x7345F0", VA = "0x107357F0")]
    private void Start()
    {
    }

    [Token(Token = "0x600AF1E")]
    [Address(RVA = "0x7357F0", Offset = "0x7345F0", VA = "0x107357F0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600AF1F")]
    [Address(RVA = "0x7357F0", Offset = "0x7345F0", VA = "0x107357F0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AF20")]
    [Address(RVA = "0x735A20", Offset = "0x734820", VA = "0x10735A20")]
    private void SetUp()
    {
    }

    [Token(Token = "0x600AF21")]
    [Address(RVA = "0x735800", Offset = "0x734600", VA = "0x10735800")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600AF22")]
    [Address(RVA = "0x735990", Offset = "0x734790", VA = "0x10735990")]
    private void SetExtraAwardImage()
    {
    }

    [Token(Token = "0x600AF23")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MasteryEmblem()
    {
    }

    [Token(Token = "0x2002711")]
    public enum PlayerType : byte
    {
      [Token(Token = "0x400B81B")] Player,
      [Token(Token = "0x400B81C")] Friend,
    }
  }
}
