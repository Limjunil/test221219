using System;
using System.Collections.Immutable;

namespace Work230102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 트럼프 카드 게임(포커 게임)
             * - 컴퓨터가 5장의 카드를 뽑는다.(플레이어가 볼 수 있음)
             * - 플레이어도 5장의 카드를 뽑는다.
             * - 플레이어는 베팅을 한다. (0~알아서)
             * - 컴퓨터는 2장의 카드를 추가로 받는다. -> 총 7장의 카드 보유
             * - 플레이어는 2장의 카드를 교체할 수 있다.(카드 1장 교체 가능한 횟수가 최대 2회 )
             * - 모든 액션이 끝난 후에는 결과를 체크한다.
             * - 플레이어가 이기면 2배로 받고, 플레이어가 지면 배팅 금액을 잃는다.
             * - 100,000 포인트 이상을 얻거나, 0포인트 이하가 되면 게임 종료
             * - 시작 포인트는 10,000 포인트
             * - 노페어, 원페어, 투페어, 트리플, 포카드, 플러쉬, 스트레이트 까지만(기본형) // 여기까지 구현했습니다.
             * ㄴ마운틴, 백스트레이트, 스티플, 로티플은 (어려움)
             */
           
            TrumpGame trumpGame = new TrumpGame();

        } // Main()
    }
}