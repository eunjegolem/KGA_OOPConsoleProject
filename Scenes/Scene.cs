using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public abstract class Scene
    {
        public string name;
        public string fieldname;
        protected ConsoleKey input;
        protected List<GameObject> gameObjects;
        //protected string targetitem;

        /// <summary>
        /// 씬의 상황 설명을 작성
        /// </summary>
        public abstract void Render();

        /// <summary>
        /// 씬의 선택지 목록을 작성
        /// </summary>
        public abstract void Choice();

        //public void Input()
        //{
        //    input = Console.ReadKey(true).Key;
        //}
        public abstract void Input();

        /// <summary>
        /// 선택지 기준으로 다시 그려주기
        /// </summary>
        public abstract void Update();
        /// <summary>
        /// 선택한 선택지를 기준으로 결과 출력
        /// </summary>
        public abstract void Result();
        
        /// <summary>
        /// 결과를 본 후 기다리기 기능 구현
        /// </summary>
        public abstract void Wait();

        /// <summary>
        /// 다음으로 넘어갈 씬 또는 게임오버를 구현
        /// </summary>
        public abstract void ChangeScene();

        //화면에 들어갈때 플레이어 위치
        public virtual void Enter() { }
        
        public virtual void Exit() { }

    }
}
