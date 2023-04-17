import { Authorize } from '@/components/Authorize';
import { WithDefaultLayout } from '@/components/DefautLayout';
import { Title } from '@/components/Title';
import { ExamNextJsClient, FoodItem, FoodItemDetailModel } from '@/functions/swagger/ExamNextJs';
import { useSwrFetcherWithAccessToken } from '@/functions/useSwrFetcherWithAccessToken';
import { Page } from '@/types/Page';
import { faCartPlus } from '@fortawesome/free-solid-svg-icons';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { Alert, notification } from 'antd';
import Link from 'next/link';
import { useRouter } from 'next/router';
import { useState } from 'react';
import useSwr from 'swr';



const FoodItemBox: React.FC<{
    foodItem: FoodItemDetailModel,
}> = ({ foodItem }) => {

    const [qty, setQty] = useState(1);

    

    return (
        <div>
            <Link href={`/restaurant/${foodItem.restaurantId}`}>Back to Food Item List</Link>
            <div className='border border-gray-400 rounded-xl p-6 flex flex-col items-center bg-white shadow-lg'>
            <div className='bg-slate-400 h-[160px] w-full'></div>
            <div className='mt-4 font-bold'>{foodItem.name}</div>
            <div className='mt-4'>{'Rp.' + foodItem.price?.toLocaleString()}</div>
            <div className='flex-[3] pl-2'>
            <div className='flex-[1]'>
                    <input value={qty} type='number' onChange={t => setQty(t.target.valueAsNumber)}
                        className='block w-full mt-2 p-1 text-sm rounded-md border-gray-500 border-solid border'></input>
                </div>
                    <button  className='block mt-2 w-full p-1 text-sm rounded-md bg-blue-500 active:bg-blue-700 text-white' type='button'>
                        <FontAwesomeIcon icon={faCartPlus} className='mr-3'></FontAwesomeIcon>
                        Add to cart
                    </button>
            </div>
        </div>
        </div>
        

    );
};

const InnerIndexPage: React.FC = () =>{
    const router = useRouter();
    const { id } = router.query;
    const restaurantDetailUri = id ? `/api/be/api/FoodItems/${id}` : undefined;
    const swrFetcher = useSwrFetcherWithAccessToken();
    const { data, error } = useSwr<FoodItem[]>(restaurantDetailUri, swrFetcher);
    return (
        <div>
            <Title>Add to Cart</Title>
            Please select how much you want to add
            <br/>
            <br/>
            {Boolean(error) && <Alert type='error' message='Cannot get Food item data' description={String(error)}></Alert>}
            <div className='grid grid-cols-5 gap-5'>
                {data?.map((x, i) => <FoodItemBox key={i} foodItem={x} />)}
            </div>
        </div>
    );
}

const IndexPage: Page = () => {
    return(
        <Authorize>
            <InnerIndexPage></InnerIndexPage>
        </Authorize>
    );
    
}

IndexPage.layout = WithDefaultLayout;
export default IndexPage;
