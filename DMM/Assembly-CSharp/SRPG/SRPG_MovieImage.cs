// Decompiled with JetBrains decompiler
// Type: SRPG.SRPG_MovieImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AF8")]
  [FlowNode.Pin(9, "Started", FlowNode.PinTypes.Output, 0)]
  [RequireComponent(typeof (CriManaMovieControllerForUI))]
  [FlowNode.Pin(10, "Finished", FlowNode.PinTypes.Output, 1)]
  public class SRPG_MovieImage : RawImage, IFlowInterface
  {
    [Token(Token = "0x400D1A7")]
    public const int PINID_STARTED = 9;
    [Token(Token = "0x400D1A8")]
    public const int PINID_FINISHED = 10;
    [Token(Token = "0x400D1A9")]
    [FieldOffset(Offset = "0x94")]
    private CriManaMovieControllerForUI mMovieController;
    [Token(Token = "0x400D1AA")]
    [FieldOffset(Offset = "0x98")]
    private bool mPlaying;

    [Token(Token = "0x600C497")]
    [Address(RVA = "0x8D0DC0", Offset = "0x8CFBC0", VA = "0x108D0DC0", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600C498")]
    [Address(RVA = "0x8D0F40", Offset = "0x8CFD40", VA = "0x108D0F40")]
    private void Update()
    {
    }

    [Token(Token = "0x600C499")]
    [Address(RVA = "0x8D0EF0", Offset = "0x8CFCF0", VA = "0x108D0EF0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600C49A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "65")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C49B")]
    [Address(RVA = "0x8D1090", Offset = "0x8CFE90", VA = "0x108D1090")]
    public SRPG_MovieImage()
    {
    }
  }
}
