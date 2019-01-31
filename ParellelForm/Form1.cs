using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParellelForm
{
    public delegate Task QueueDelegate(CancellationToken ctk);

    public partial class Form1 : Form
    {

        private ConcurrentQueue<QueueDelegate> waitingTasks = new ConcurrentQueue<QueueDelegate>();


        private ConcurrentQueue<Tarefa> waitingTasks2 = new ConcurrentQueue<Tarefa>();


        private ConcurrentBag<Tarefa> processingTasks = new ConcurrentBag<Tarefa>();

        private SemaphoreSlim semaphore = new SemaphoreSlim(2);



        #region BackgroundWorker
        private BackgroundWorker backgroundWorker1 = new BackgroundWorker();
        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler((a, b) => { });
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler((a, b) => { });
            backgroundWorker1.RunWorkerAsync();
        } 
        #endregion

        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            while (true)
            {
                waitingTasks2.TryDequeue(out var workItem);

                if (workItem != null)
                {
                    semaphore.Wait(workItem.cToken);

                    this.Invoke((MethodInvoker)(() => processingStack.Items.Add(waitingStack.Items[0])));
                    this.Invoke((MethodInvoker)(() => waitingStack.Items.RemoveAt(0)));

                    //Task tafera = Task.WhenAll(workItem.Invoke());
                    processingTasks.Add(workItem);
                }

               

                Thread.Sleep(500);
            }
        }       

        private async Task TaskExample(CancellationToken ctk)
        {

            try
            {
                //Verifica antes de iniciar a tarefa
                ctk.ThrowIfCancellationRequested();

                for (int i = 0; i < 5; i++)
                {
                    //Verifica durante a tarefa
                    ctk.ThrowIfCancellationRequested();
                    await Task.Delay(1000);
                }

                //Verifica após tarefa ser concluida
                ctk.ThrowIfCancellationRequested();

                MessageBox.Show("Task finalizada!");
                semaphore.Release();
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Task cancelada!");

            }

        }

        #region Eventos
        private void addTaskButton_Click(object sender, EventArgs e)
        {

            Tarefa task = new Tarefa()
            {
                Delegate = new QueueDelegate(TaskExample),
                Descricao = "Tarefa"
            };


            waitingTasks2.Enqueue(task);

            waitingStack.Items.Add("Teste");
        }

        private void cancelTaskButton_Click(object sender, EventArgs e)
        {
            var test = processingStack.SelectedIndex;
            processingTasks.ElementAt(test).cTokenSource.Cancel();
        } 
        #endregion
    }
}
