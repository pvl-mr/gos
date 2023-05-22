interface Props {
    temp: number;
    date: string;
}

function formatDate(isoDate: string): string {
    const date = new Date(isoDate);
    const options: any  = {
      year: 'numeric',
      month: 'long',
      day: 'numeric',
      hour: 'numeric',
      minute: 'numeric'
    };
    return date.toLocaleString('ru-RU', options);
  }
  


const WeatherInfo = (props: Props) => {
    return <div>
        <div>{props.temp}</div>
        <div>{formatDate(props.date)}</div>
    </div>
}

export default WeatherInfo;
